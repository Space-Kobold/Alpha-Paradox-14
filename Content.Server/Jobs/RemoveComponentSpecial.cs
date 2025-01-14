// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server.Jobs;

public sealed partial class RemoveComponentSpecial : JobSpecial
{
    [DataField(required: true)]
    public ComponentRegistry Components { get; private set; } = new();

    public override void AfterEquip(EntityUid mob)
    {
        var entMan = IoCManager.Resolve<IEntityManager>();
        entMan.RemoveComponents(mob, Components);
    }
}
