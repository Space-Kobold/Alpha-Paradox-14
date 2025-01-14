// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage;
using Robust.Shared.Audio;

namespace Content.Server.Weapons.Melee.WeaponRandom;

[RegisterComponent]
internal sealed partial class WeaponRandomComponent : Component
{

    /// <summary>
    /// Amount of damage that will be caused. This is specified in the yaml.
    /// </summary>
    [DataField("damageBonus")]
    public DamageSpecifier DamageBonus = new();

    /// <summary>
    /// Chance for the damage bonus to occur (1 = 100%).
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float RandomDamageChance = 0.00001f;

    /// <summary>
    /// Sound effect to play when the damage bonus occurs.
    /// </summary>
    [DataField("damageSound")]
    public SoundSpecifier DamageSound = new SoundPathSpecifier("/Audio/Items/bikehorn.ogg");

}
