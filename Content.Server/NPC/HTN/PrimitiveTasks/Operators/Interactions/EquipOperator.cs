// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Hands.Systems;

namespace Content.Server.NPC.HTN.PrimitiveTasks.Operators.Interactions;

public sealed partial class EquipOperator : HTNOperator
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    [DataField("target")]
    public string Target = "Target";

    public override HTNOperatorStatus Update(NPCBlackboard blackboard, float frameTime)
    {
        if (!blackboard.TryGetValue<EntityUid>(Target, out var target, _entManager))
        {
            return HTNOperatorStatus.Failed;
        }

        var owner = blackboard.GetValue<EntityUid>(NPCBlackboard.Owner);
        var handsSystem = _entManager.System<HandsSystem>();

        // TODO: As elsewhere need some generic interaction cooldown system
        if (handsSystem.TryPickup(owner, target))
        {
            return HTNOperatorStatus.Finished;
        }

        return HTNOperatorStatus.Failed;
    }
}
