// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Weapons.Ranged.Events;

/// <summary>
/// Raised directed on the gun when trying to fire it while it's out of ammo
/// </summary>
[ByRefEvent]
public record struct OnEmptyGunShotEvent(EntityUid EmptyGun);
