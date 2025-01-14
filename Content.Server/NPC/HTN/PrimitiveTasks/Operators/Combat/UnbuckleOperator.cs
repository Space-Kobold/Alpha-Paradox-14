// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Buckle.Systems;

namespace Content.Server.NPC.HTN.PrimitiveTasks.Operators.Combat;

public sealed partial class UnbuckleOperator : HTNOperator
{
    private BuckleSystem _buckle = default!;

    [DataField("shutdownState")]
    public HTNPlanState ShutdownState { get; private set; } = HTNPlanState.TaskFinished;

    public override void Initialize(IEntitySystemManager sysManager)
    {
        base.Initialize(sysManager);
        _buckle = sysManager.GetEntitySystem<BuckleSystem>();
    }

    public override void Startup(NPCBlackboard blackboard)
    {
        base.Startup(blackboard);
        var owner = blackboard.GetValue<EntityUid>(NPCBlackboard.Owner);
        _buckle.TryUnbuckle(owner, owner, false);
    }

    public override HTNOperatorStatus Update(NPCBlackboard blackboard, float frameTime)
    {
        return HTNOperatorStatus.Finished;
    }
}
