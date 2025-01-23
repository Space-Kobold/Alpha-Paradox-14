using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared._APCore.Chemistry.Registry.Systems;
using Content.Shared.Administration.Logs;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Reaction;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.Database;
using Content.Shared.EntityEffects;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Shared.Chemistry;

[UsedImplicitly]
public sealed class ReactiveSystem : EntitySystem
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly IRobustRandom _robustRandom = default!;
    [Dependency] private readonly ISharedAdminLogManager _adminLogger = default!;
    [Dependency] private readonly ChemRegistrySystem _chemRegistry = default!;

    public void DoEntityReaction(EntityUid uid, Solution solution, ReactionMethod method)
    {
        foreach (var reagent in solution.Contents.ToArray())
        {
            ReactionEntity(uid, method, reagent, solution);
        }
    }

    public void ReactionEntity(EntityUid uid, ReactionMethod method, ReagentQuantity reagentQuantity, Solution? source)
    {
        // We throw if the reagent specified doesn't exist.
        var reagent = _chemRegistry.IndexReagent(reagentQuantity.Reagent.Prototype);
        ReactionEntity(uid, method, reagent, reagentQuantity, source);
    }

    public void ReactionEntity(EntityUid uid,
        ReactionMethod method,
        ReagentDefinition reagent,
        ReagentQuantity reagentQuantity,
        Solution? source)
    {
        if (!TryComp(uid, out ReactiveComponent? reactive))
            return;

        // If we have a source solution, use the reagent quantity we have left. Otherwise, use the reaction volume specified.
        var args = new EntityEffectReagentArgs(uid, EntityManager, null, source, source?.GetReagentQuantity(reagentQuantity.Reagent) ?? reagentQuantity.Quantity, proto, method, 1f);

        // First, check if the reagent wants to apply any effects.
        if (reagent.ReactiveEffects != null && reactive.ReactiveGroups != null)
        {
            foreach (var (key, val) in reagent.ReactiveEffects)
            {
                if (!val.Methods.Contains(method))
                    continue;

                if (!reactive.ReactiveGroups.ContainsKey(key))
                    continue;

                if (!reactive.ReactiveGroups[key].Contains(method))
                    continue;

                foreach (var effect in val.Effects)
                {
                    if (!effect.ShouldApply(args, _robustRandom))
                        continue;

                    if (effect.ShouldLog)
                    {
                        var entity = args.TargetEntity;
                        _adminLogger.Add(LogType.ReagentEffect, effect.LogImpact,
                            $"Reactive effect {effect.GetType().Name:effect} of reagent {reagent.ID:reagent} " +
                            $"with method {method} applied on entity {ToPrettyString(entity):entity}" +
                            $" at {Transform(entity).Coordinates:coordinates}");
                    }

                    effect.Effect(args);
                }
            }
        }

        // Then, check if the prototype has any effects it can apply as well.
        if (reactive.Reactions != null)
        {
            foreach (var entry in reactive.Reactions)
            {
                if (!entry.Methods.Contains(method))
                    continue;

                if (entry.Reagents != null && !entry.Reagents.Contains(reagent.Id))
                    continue;

                foreach (var effect in entry.Effects)
                {
                    if (!effect.ShouldApply(args, _robustRandom))
                        continue;

                    if (effect.ShouldLog)
                    {
                        var entity = args.TargetEntity;
                        _adminLogger.Add(LogType.ReagentEffect,
                            effect.LogImpact,
                            $"Reactive effect {effect.GetType().Name:effect} of " +
                            $"{ToPrettyString(entity):entity} using reagent {reagent.Id:reagent} with method {method}" +
                            $" at {Transform(entity).Coordinates:coordinates}");
                    }

                    effect.Effect(args);
                }
            }
        }
    }
}
public enum ReactionMethod
{
Touch,
Injection,
Ingestion,
}
