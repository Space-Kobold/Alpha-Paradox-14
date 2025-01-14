// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Weapons.Ranged.Events;

/// <summary>
/// Raised on a gun when projectiles have been fired from it.
/// </summary>
public sealed class AmmoShotEvent : EntityEventArgs
{
    public List<EntityUid> FiredProjectiles = default!;
}
