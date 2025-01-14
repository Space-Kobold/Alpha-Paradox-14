// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Gatherable.Components;
using Content.Shared.Projectiles;
using Robust.Shared.Physics.Events;

namespace Content.Server.Gatherable;

public sealed partial class GatherableSystem
{
    private void InitializeProjectile()
    {
        SubscribeLocalEvent<GatheringProjectileComponent, StartCollideEvent>(OnProjectileCollide);
    }

    private void OnProjectileCollide(Entity<GatheringProjectileComponent> gathering, ref StartCollideEvent args)
    {
        if (!args.OtherFixture.Hard ||
            args.OurFixtureId != SharedProjectileSystem.ProjectileFixture ||
            gathering.Comp.Amount <= 0 ||
            !TryComp<GatherableComponent>(args.OtherEntity, out var gatherable))
        {
            return;
        }

        Gather(args.OtherEntity, gathering, gatherable);
        gathering.Comp.Amount--;

        if (gathering.Comp.Amount <= 0)
            QueueDel(gathering);
    }
}
