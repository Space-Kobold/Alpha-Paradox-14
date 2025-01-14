// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Nutrition.Components;
using Content.Shared.Clothing;

namespace Content.Server.Nutrition.EntitySystems;

public sealed class IngestionBlockerSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<IngestionBlockerComponent, ItemMaskToggledEvent>(OnBlockerMaskToggled);
    }

    private void OnBlockerMaskToggled(Entity<IngestionBlockerComponent> ent, ref ItemMaskToggledEvent args)
    {
        ent.Comp.Enabled = !args.IsToggled;
    }
}
