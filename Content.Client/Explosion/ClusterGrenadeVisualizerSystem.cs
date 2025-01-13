// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Explosion;
using Content.Shared.Explosion.Components;
using Robust.Client.GameObjects;

namespace Content.Client.Explosion;

public sealed class ClusterGrenadeVisualizerSystem : VisualizerSystem<ClusterGrenadeVisualsComponent>
{
    protected override void OnAppearanceChange(EntityUid uid, ClusterGrenadeVisualsComponent comp, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        if (AppearanceSystem.TryGetData<int>(uid, ClusterGrenadeVisuals.GrenadesCounter, out var grenadesCounter, args.Component))
            args.Sprite.LayerSetState(0, $"{comp.State}-{grenadesCounter}");
    }
}
