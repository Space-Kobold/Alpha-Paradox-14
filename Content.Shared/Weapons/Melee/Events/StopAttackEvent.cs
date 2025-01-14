// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Weapons.Melee.Events;

[Serializable, NetSerializable]
public sealed class StopAttackEvent : EntityEventArgs
{
    public readonly NetEntity Weapon;

    public StopAttackEvent(NetEntity weapon)
    {
        Weapon = weapon;
    }
}
