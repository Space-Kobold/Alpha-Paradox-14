// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Light;
using Content.Shared.Light.Components;
using Robust.Shared.GameObjects;

namespace Content.Server.Light.EntitySystems;

public sealed class RotatingLightSystem : SharedRotatingLightSystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<RotatingLightComponent, PointLightToggleEvent>(OnLightToggle);
    }

    private void OnLightToggle(EntityUid uid, RotatingLightComponent comp, PointLightToggleEvent args)
    {
        if (comp.Enabled == args.Enabled)
            return;

        comp.Enabled = args.Enabled;
        Dirty(uid, comp);
    }
}
