// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry.Components;
using Content.Shared.Chemistry.Reaction;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Prototypes;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public partial class ChemRegistrySystem
{
    public IEnumerable<ReagentDefinition> EnumerateReagentPrototypes()
    {
        foreach (var oldReagent in _prototypeManager.EnumeratePrototypes<ReagentPrototype>())
        {
            yield return oldReagent;
        }
        foreach (var (_, defComp) in
                 _entProtoCache.EnumerateEntPrototypesWithComp<ReagentDefinitionComponent>())
        {
            yield return defComp.Definition;
        }
    }

    public IEnumerable<ReactionDefinition> EnumerateReactionPrototypes()
    {
        foreach (var oldReactant in _prototypeManager.EnumeratePrototypes<ReactionPrototype>())
        {
            yield return oldReactant;
        }
        foreach (var (_, defComp) in
                 _entProtoCache.EnumerateEntPrototypesWithComp<ReactionDefinitionComponent>())
        {
            yield return defComp.Definition;
        }
    }

    private bool CheckProtoReload(PrototypesReloadedEventArgs args)
    {
        return args.ByType.ContainsKey(typeof(ReagentPrototype)) || args.ByType.ContainsKey(typeof(ReactionPrototype));
    }
}
