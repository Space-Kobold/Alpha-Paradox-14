// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Temperature;
using Content.Shared.Temperature.Components;

namespace Content.Shared.Temperature.Systems;

public sealed class AlwaysHotSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AlwaysHotComponent, IsHotEvent>(OnIsHot);
    }

    private void OnIsHot(Entity<AlwaysHotComponent> ent, ref IsHotEvent args)
    {
        args.IsHot = true;
    }
}
