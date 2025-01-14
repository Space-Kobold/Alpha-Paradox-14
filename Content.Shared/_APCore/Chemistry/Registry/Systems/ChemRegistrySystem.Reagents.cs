// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using System.Diagnostics.CodeAnalysis;
using Content.Shared._APCore.Chemistry.Reagents;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public sealed partial class ChemRegistrySystem
{
    public void RegisterReagent(ReagentDefinition reagent)
    {
        var chemReg = EnsureRegistry().Comp;
        chemReg.Reagents.Add(reagent.Id, reagent);
    }

    public bool TryRegisterReagent(ReagentDefinition reagent, bool logDuplicates = true)
    {
        var chemReg = EnsureRegistry();
        if (chemReg.Comp.Reagents.TryAdd(reagent.Id, reagent))
            return true;
        if (logDuplicates)
            Log.Error($"Tried to register duplicate reaction id:{reagent.Id} in registry on {ToPrettyString(chemReg)}");
        return false;
    }

    public ReagentDefinition IndexReagent(string id)
    {
        var chemReg = EnsureRegistry().Comp;
        return chemReg.Reagents[id];
    }

    public bool TryIndexReagent(string id, [NotNullWhen(true)]out ReagentDefinition? reagent, bool logMissing = true)
    {
        var chemReg = EnsureRegistry();
        if (chemReg.Comp.Reagents.TryGetValue(id, out reagent))
            return true;
        if (logMissing)
            Log.Error($"Reagent with Id:{id} could not be found in registry on {ToPrettyString(chemReg)}!");
        return false;
    }
}
