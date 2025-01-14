// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Construction.Components;
using Content.Shared.SubFloor;
using Robust.Shared.Map.Components;

namespace Content.Server.SubFloor;

public sealed class SubFloorHideSystem : SharedSubFloorHideSystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<SubFloorHideComponent, AnchorAttemptEvent>(OnAnchorAttempt);
        SubscribeLocalEvent<SubFloorHideComponent, UnanchorAttemptEvent>(OnUnanchorAttempt);
    }

    private void OnAnchorAttempt(EntityUid uid, SubFloorHideComponent component, AnchorAttemptEvent args)
    {
        // No teleporting entities through floor tiles when anchoring them.
        var xform = Transform(uid);

        if (TryComp<MapGridComponent>(xform.GridUid, out var grid)
            && HasFloorCover(xform.GridUid.Value, grid, Map.TileIndicesFor(xform.GridUid.Value, grid, xform.Coordinates)))
        {
            args.Cancel();
        }
    }

    private void OnUnanchorAttempt(EntityUid uid, SubFloorHideComponent component, UnanchorAttemptEvent args)
    {
        // No un-anchoring things under the floor. Only required for something like vents, which are still interactable
        // despite being partially under the floor.
        if (component.IsUnderCover)
            args.Cancel();
    }
}
