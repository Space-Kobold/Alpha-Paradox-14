// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NPC.HTN.Preconditions;

public sealed partial class HasOrdersPrecondition : HTNPrecondition
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    [DataField("orders", required: true)] public Enum Orders = default!;

    public override bool IsMet(NPCBlackboard blackboard)
    {
        return Equals(blackboard.GetValueOrDefault<Enum>(NPCBlackboard.CurrentOrders, _entManager), Orders);
    }
}
