// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage;

namespace Content.Server.Mining;

/// <summary>
/// This is used for meteors which hit objects, dealing damage to destroy/kill the object and dealing equal damage back to itself.
/// </summary>
[RegisterComponent, Access(typeof(MeteorSystem))]
public sealed partial class MeteorComponent : Component
{
    /// <summary>
    /// Damage specifier that is multiplied against the calculated damage amount to determine what damage is applied to the colliding entity.
    /// </summary>
    /// <remarks>
    /// The values of this should add up to 1 or else the damage will be scaled.
    /// </remarks>
    [DataField]
    public DamageSpecifier DamageTypes = new();

    /// <summary>
    /// A list of entities that this meteor has collided with. used to ensure no double collisions occur.
    /// </summary>
    [DataField]
    public HashSet<EntityUid> HitList = new();
}
