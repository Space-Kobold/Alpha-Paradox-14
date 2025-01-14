// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Access.Components;
using Content.Shared.Item.ItemToggle.Components;

namespace Content.Shared.Access.Systems;

public sealed class AccessToggleSystem : EntitySystem
{
    [Dependency] private readonly SharedAccessSystem _access = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AccessToggleComponent, ItemToggledEvent>(OnToggled);
    }

    private void OnToggled(Entity<AccessToggleComponent> ent, ref ItemToggledEvent args)
    {
        _access.SetAccessEnabled(ent, args.Activated);
    }
}
