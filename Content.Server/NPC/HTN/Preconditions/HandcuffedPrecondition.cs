// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Cuffs;
using Content.Shared.Cuffs.Components;

namespace Content.Server.NPC.HTN.Preconditions;

public sealed partial class HandcuffedPrecondition : HTNPrecondition
{
    [Dependency] private readonly IEntityManager _entManager = default!;

    [DataField]
    public bool ReactOnlyWhenFullyCuffed = true;

    public override bool IsMet(NPCBlackboard blackboard)
    {
        var cuffable = _entManager.System<CuffableSystem>();
        var owner = blackboard.GetValue<EntityUid>(NPCBlackboard.Owner);

        if (!_entManager.TryGetComponent<CuffableComponent>(owner, out var cuffComp))
            return false;

        var target = (owner, cuffComp);

        return cuffable.IsCuffed(target, ReactOnlyWhenFullyCuffed);
    }

}
