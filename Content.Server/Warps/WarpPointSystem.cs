// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Examine;
using Content.Shared.Ghost;

namespace Content.Server.Warps;

public sealed class WarpPointSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<WarpPointComponent, ExaminedEvent>(OnWarpPointExamine);
    }

    private void OnWarpPointExamine(EntityUid uid, WarpPointComponent component, ExaminedEvent args)
    {
        if (!HasComp<GhostComponent>(args.Examiner))
            return;

        var loc = component.Location == null ? "<null>" : $"'{component.Location}'";
        args.PushText(Loc.GetString("warp-point-component-on-examine-success", ("location", loc)));
    }
}
