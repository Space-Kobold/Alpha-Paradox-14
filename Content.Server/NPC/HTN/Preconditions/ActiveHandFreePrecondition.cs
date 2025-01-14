// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Hands.Components;

namespace Content.Server.NPC.HTN.Preconditions;

/// <summary>
/// Returns true if the active hand is unoccupied.
/// </summary>
public sealed partial class ActiveHandFreePrecondition : HTNPrecondition
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    public override bool IsMet(NPCBlackboard blackboard)
    {
        return blackboard.TryGetValue<bool>(NPCBlackboard.ActiveHandFree, out var handFree, _entManager) && handFree;
    }
}
