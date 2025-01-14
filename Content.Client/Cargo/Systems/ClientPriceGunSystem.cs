// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Cargo.Components;
using Content.Shared.Timing;
using Content.Shared.Cargo.Systems;

namespace Content.Client.Cargo.Systems;

/// <summary>
/// This handles...
/// </summary>
public sealed class ClientPriceGunSystem : SharedPriceGunSystem
{
    [Dependency] private readonly UseDelaySystem _useDelay = default!;

    protected override bool GetPriceOrBounty(Entity<PriceGunComponent> entity, EntityUid target, EntityUid user)
    {
        if (!TryComp(entity, out UseDelayComponent? useDelay) || _useDelay.IsDelayed((entity, useDelay)))
            return false;

        // It feels worse if the cooldown is predicted but the popup isn't! So only do the cooldown reset on the server.
        return true;
    }
}
