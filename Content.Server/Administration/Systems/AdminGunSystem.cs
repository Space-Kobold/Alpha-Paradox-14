// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Administration.Components;
using Content.Shared.Weapons.Ranged.Events;

namespace Content.Server.Administration.Systems;

public sealed class AdminGunSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<AdminMinigunComponent, GunRefreshModifiersEvent>(OnGunRefreshModifiers);
    }

    private void OnGunRefreshModifiers(Entity<AdminMinigunComponent> ent, ref GunRefreshModifiersEvent args)
    {
        args.FireRate = 15;
    }
}
