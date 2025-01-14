// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage;

namespace Content.Shared.Wieldable.Components;

[RegisterComponent, Access(typeof(WieldableSystem))]
public sealed partial class IncreaseDamageOnWieldComponent : Component
{
    [DataField("damage", required: true)]
    public DamageSpecifier BonusDamage = default!;
}
