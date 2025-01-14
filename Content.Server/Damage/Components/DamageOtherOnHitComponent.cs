// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Damage.Systems;
using Content.Shared.Damage;

namespace Content.Server.Damage.Components
{
    [Access(typeof(DamageOtherOnHitSystem))]
    [RegisterComponent]
    public sealed partial class DamageOtherOnHitComponent : Component
    {
        [DataField("ignoreResistances")]
        [ViewVariables(VVAccess.ReadWrite)]
        public bool IgnoreResistances = false;

        [DataField("damage", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier Damage = default!;

    }
}
