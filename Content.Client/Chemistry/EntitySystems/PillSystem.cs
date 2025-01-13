// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chemistry.Components;
using Robust.Client.GameObjects;

namespace Content.Client.Chemistry.EntitySystems;

public sealed class PillSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<PillComponent, AfterAutoHandleStateEvent>(OnHandleState);
    }

    private void OnHandleState(EntityUid uid, PillComponent component, ref AfterAutoHandleStateEvent args)
    {
        if (!TryComp(uid, out SpriteComponent? sprite))
            return;

        if (!sprite.TryGetLayer(0, out var layer))
            return;

        layer.SetState($"pill{component.PillType + 1}");
    }
}
