// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Roles;

public sealed class RoleBriefingSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RoleBriefingComponent, GetBriefingEvent>(OnGetBriefing);
    }

    private void OnGetBriefing(EntityUid uid, RoleBriefingComponent comp, ref GetBriefingEvent args)
    {
        args.Append(Loc.GetString(comp.Briefing));
    }
}
