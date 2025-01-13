// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Storage;
using Content.Shared.Storage.Components;
using Robust.Client.GameObjects;

namespace Content.Client.Storage.Visualizers;

public sealed class StorageFillVisualizerSystem : VisualizerSystem<StorageFillVisualizerComponent>
{
    protected override void OnAppearanceChange(EntityUid uid, StorageFillVisualizerComponent component, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        if (!TryComp(uid, out SpriteComponent? sprite))
            return;

        if (!AppearanceSystem.TryGetData<int>(uid, StorageFillVisuals.FillLevel, out var level, args.Component))
            return;

        var state = $"{component.FillBaseName}-{level}";
        args.Sprite.LayerSetState(StorageFillLayers.Fill, state);
    }
}
