// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Mech;
using Robust.Client.GameObjects;

namespace Content.Client.Mech;

/// <summary>
/// Handles the sprite state changes while
/// constructing mech assemblies.
/// </summary>
public sealed class MechAssemblyVisualizerSystem : VisualizerSystem<MechAssemblyVisualsComponent>
{
    protected override void OnAppearanceChange(EntityUid uid, MechAssemblyVisualsComponent component,
        ref AppearanceChangeEvent args)
    {
        base.OnAppearanceChange(uid, component, ref args);

        if (!AppearanceSystem.TryGetData<int>(uid, MechAssemblyVisuals.State, out var stage, args.Component))
            return;

        var state = component.StatePrefix + stage;

        args.Sprite?.LayerSetState(0, state);
    }
}
