// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Item.ItemToggle.Components;
using Content.Shared.Toggleable;
using ItemTogglePointLightComponent = Content.Shared.Light.Components.ItemTogglePointLightComponent;

namespace Content.Shared.Light.EntitySystems;

/// <summary>
/// Handles ItemToggle for PointLight
/// </summary>
public sealed class ItemTogglePointLightSystem : EntitySystem
{
    [Dependency] private readonly SharedAppearanceSystem _appearance = default!;
    [Dependency] private readonly SharedPointLightSystem _light = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ItemTogglePointLightComponent, ItemToggledEvent>(OnLightToggled);
    }

    private void OnLightToggled(Entity<ItemTogglePointLightComponent> ent, ref ItemToggledEvent args)
    {
        if (!_light.TryGetLight(ent.Owner, out var light))
            return;

        _appearance.SetData(ent, ToggleableLightVisuals.Enabled, args.Activated);
        _light.SetEnabled(ent.Owner, args.Activated, comp: light);
    }
}
