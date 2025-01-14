// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;
using Robust.Shared.Serialization;

namespace Content.Shared.Weapons.Melee.Events;

/// <summary>
/// Raised when a light attack is made.
/// </summary>
[Serializable, NetSerializable]
public sealed class LightAttackEvent : AttackEvent
{
    public readonly NetEntity? Target;
    public readonly NetEntity Weapon;

    public LightAttackEvent(NetEntity? target, NetEntity weapon, NetCoordinates coordinates) : base(coordinates)
    {
        Target = target;
        Weapon = weapon;
    }
}
