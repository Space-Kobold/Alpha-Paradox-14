// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using System.Diagnostics.CodeAnalysis;
using Content.Shared._APCore.Chemistry.Registry.Components;
using Content.Shared._APCore.Core.EntPrototypes;
using Robust.Shared.Map;
using Robust.Shared.Prototypes;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public sealed partial class ChemRegistrySystem : EntitySystem
{
    [Dependency] private readonly EntProtoCache _entProtoCache = default!;
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

    private Entity<ChemRegistryComponent>? _cachedRegistry;
    public override void Initialize()
    {
        _prototypeManager.PrototypesReloaded += OnPrototypesReloaded;
        SubscribeLocalEvent<ChemRegistryComponent, ComponentInit>(OnRegistryCompInit);
    }

    private void OnRegistryCompInit(Entity<ChemRegistryComponent> ent, ref ComponentInit args)
    {
        if (_cachedRegistry != null)
        {
            if (_cachedRegistry.Value.Comp.IsBuilt)
                BuildRegistry(ent);
            if (_cachedRegistry == ent)
                return;
            Log.Error($"Tried to initialize ChemRegistry on Entity:{ToPrettyString(ent)} " +
                      $"when one already exists on {ToPrettyString(_cachedRegistry.Value)}. {ToPrettyString(ent)}." +
                      $"The registry on the duplicate will not be built!");
            return;
        }
        _cachedRegistry = ent;
        BuildRegistry(ent);
    }

    private void OnPrototypesReloaded(PrototypesReloadedEventArgs args)
    {
        if (!args.ByType.ContainsKey(typeof(EntityPrototype))
            || !CheckProtoReload(args))
            return;
        var chemReg = EnsureRegistry();
        ClearRegistry(false);
        BuildRegistry(chemReg);
    }

    public Entity<ChemRegistryComponent> EnsureRegistry()
    {
        if (_cachedRegistry != null)
        {
            if (!_cachedRegistry.Value.Comp.IsBuilt)
                BuildRegistry(_cachedRegistry.Value);
            return _cachedRegistry.Value;
        }
        var ent = EntityManager.SpawnEntity(null, MapCoordinates.Nullspace);
        var comp = EntityManager.AddComponent<ChemRegistryComponent>(ent);
        var newReg = new Entity<ChemRegistryComponent>(ent, comp);//cached registry is set by comp init. Do NOT set it here!
        BuildRegistry(newReg);
        return newReg;
    }

    private void BuildRegistry(Entity<ChemRegistryComponent> chemReg, bool dirty = true)
    {
        Log.Debug($"Building Chem Registry, Ent:{ToPrettyString(chemReg)}");
        foreach (var reagent in EnumerateReagentPrototypes())
        {
            chemReg.Comp.Reagents.Add(reagent.Id, reagent);
        }
        foreach (var reaction in EnumerateReactionPrototypes())
        {
            chemReg.Comp.Reactions.Add(reaction.Id, reaction);
        }
        if (dirty)
            Dirty(chemReg);
    }

    private void ClearRegistry(bool dirty = true)
    {
        if (_cachedRegistry == null)
            return;
        Log.Debug($"Clearing Chem Registry, Ent:{ToPrettyString(_cachedRegistry.Value)}");
        _cachedRegistry.Value.Comp.Reagents.Clear();
        _cachedRegistry.Value.Comp.Reactions.Clear();
        if (dirty)
            Dirty(_cachedRegistry.Value);
    }
}
