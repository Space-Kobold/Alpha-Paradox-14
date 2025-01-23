// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using System.Diagnostics.CodeAnalysis;
using Content.Shared._APCore.Chemistry.Reagents;

namespace Content.Shared._APCore.Chemistry.Registry.Systems;

public sealed partial class ChemRegistrySystem
{
    public void RegisterReaction(ReactionDefinition reaction)
    {
        Reactions.Add(reaction.Id, reaction);
    }

    public bool TryRegisterReaction(ReactionDefinition reaction, bool logDuplicates = true)
    {
        if (Reactions.TryAdd(reaction.Id, reaction))
            return true;
        if (logDuplicates)
            Log.Error($"Tried to register duplicate reaction id:{reaction.Id} in registry on {ToPrettyString(RegistryEntity)}");
        return false;
    }

    public ReactionDefinition IndexReaction(string id)
    {
        return Reactions[id];
    }

    public IEnumerable<ReactionDefinition> EnumerateReactions()
    {
        foreach (var (_,data) in Reactions)
        {
            yield return data;
        }
    }

    public bool ReactionIsDefined(ReagentId id)
    {
        return Reactions.ContainsKey(id);
    }

    public bool TryIndexReaction(ReagentId id, [NotNullWhen(true)]out ReactionDefinition? reaction, bool logMissing = true)
    {
        if (Reactions.TryGetValue(id, out reaction))
            return true;
        if (logMissing)
            Log.Error($"Reagent with Id:{id} could not be found in registry on {ToPrettyString(RegistryEntity)}!");
        return false;
    }
}
