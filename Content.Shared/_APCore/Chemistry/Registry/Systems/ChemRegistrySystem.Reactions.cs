// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using System.Diagnostics.CodeAnalysis;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public sealed partial class ChemRegistrySystem
{
    public void RegisterReaction(ReactionDefinition reaction)
    {
        var chemReg = EnsureRegistry().Comp;
        chemReg.Reactions.Add(reaction.Id, reaction);
    }

    public bool TryRegisterReaction(ReactionDefinition reaction, bool logDuplicates = true)
    {
        var chemReg = EnsureRegistry();
        if (chemReg.Comp.Reactions.TryAdd(reaction.Id, reaction))
            return true;
        if (logDuplicates)
            Log.Error($"Tried to register duplicate reaction id:{reaction.Id} in registry on {ToPrettyString(chemReg)}");
        return false;
    }

    public ReactionDefinition IndexReaction(string id)
    {
        var chemReg = EnsureRegistry().Comp;
        return chemReg.Reactions[id];
    }

    public bool TryIndexReaction(string id, [NotNullWhen(true)]out ReactionDefinition? reaction, bool logMissing = true)
    {
        var chemReg = EnsureRegistry();
        if (chemReg.Comp.Reactions.TryGetValue(id, out reaction))
            return true;
        if (logMissing)
            Log.Error($"Reagent with Id:{id} could not be found in registry on {ToPrettyString(chemReg)}!");
        return false;
    }
}
