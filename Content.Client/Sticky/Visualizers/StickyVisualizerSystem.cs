// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Sticky.Components;
using Robust.Client.GameObjects;

namespace Content.Client.Sticky.Visualizers;

public sealed class StickyVisualizerSystem : VisualizerSystem<StickyVisualizerComponent>
{
    private EntityQuery<SpriteComponent> _spriteQuery;

    public override void Initialize()
    {
        base.Initialize();

        _spriteQuery = GetEntityQuery<SpriteComponent>();

        SubscribeLocalEvent<StickyVisualizerComponent, ComponentInit>(OnInit);
    }

    private void OnInit(Entity<StickyVisualizerComponent> ent, ref ComponentInit args)
    {
        if (!_spriteQuery.TryComp(ent, out var sprite))
            return;

        ent.Comp.OriginalDrawDepth = sprite.DrawDepth;
    }

    protected override void OnAppearanceChange(EntityUid uid, StickyVisualizerComponent comp, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        if (!AppearanceSystem.TryGetData<bool>(uid, StickyVisuals.IsStuck, out var isStuck, args.Component))
            return;

        var drawDepth = isStuck ? comp.StuckDrawDepth : comp.OriginalDrawDepth;
        args.Sprite.DrawDepth = drawDepth;
    }
}
