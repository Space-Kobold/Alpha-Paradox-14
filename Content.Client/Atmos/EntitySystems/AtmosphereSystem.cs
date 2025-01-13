// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Atmos.Components;
using Content.Shared.Atmos.Components;
using Content.Shared.Atmos.EntitySystems;
using Robust.Shared.GameStates;

namespace Content.Client.Atmos.EntitySystems;

public sealed class AtmosphereSystem : SharedAtmosphereSystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<MapAtmosphereComponent, ComponentHandleState>(OnMapHandleState);
    }

    private void OnMapHandleState(EntityUid uid, MapAtmosphereComponent component, ref ComponentHandleState args)
    {
        if (args.Current is not MapAtmosphereComponentState state)
            return;

        // Struct so should just copy by value.
        component.OverlayData = state.Overlay;
    }
}
