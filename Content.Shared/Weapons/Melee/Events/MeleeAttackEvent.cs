// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Weapons.Melee.Events;

/// <summary>
/// Event raised on the user after attacking with a melee weapon, regardless of whether it hit anything.
/// </summary>
[ByRefEvent]
public record struct MeleeAttackEvent(EntityUid Weapon);
