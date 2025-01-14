// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.NPC;

namespace Content.Server.NPC.Components;

public abstract partial class NPCComponent : SharedNPCComponent
{
    /// <summary>
    /// Contains all of the world data for a particular NPC in terms of how it sees the world.
    /// </summary>
    [DataField("blackboard", customTypeSerializer: typeof(NPCBlackboardSerializer))]
    public NPCBlackboard Blackboard = new();
}
