// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry.Components;
using Content.Shared.Chemistry.Reaction;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Prototypes;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public partial class ChemRegistrySystem
{
    private void BuildLegacyRegistry(ChemRegistryComponent registry)
    {
        foreach (var oldReagent in _prototypeManager.EnumeratePrototypes<ReagentPrototype>())
        {
            registry.Reagents.Add(oldReagent.ID, oldReagent);
        }
        foreach (var oldReactant in _prototypeManager.EnumeratePrototypes<ReagentPrototype>())
        {
            registry.Reagents.Add(oldReactant.ID, oldReactant);
        }
    }

    private bool CheckLegacyReload(PrototypesReloadedEventArgs args)
    {
        return args.ByType.ContainsKey(typeof(ReagentPrototype)) || args.ByType.ContainsKey(typeof(ReactionPrototype));
    }
}
