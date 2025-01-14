// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Alert;
using Robust.Shared.Prototypes;

namespace Content.Shared.StatusEffect
{
    [Prototype("statusEffect")]
    public sealed partial class StatusEffectPrototype : IPrototype
    {
        [IdDataField]
        public string ID { get; private set; } = default!;

        [DataField("alert")]
        public ProtoId<AlertPrototype>? Alert { get; private set; }

        /// <summary>
        ///     Whether a status effect should be able to apply to any entity,
        ///     regardless of whether it is in ALlowedEffects or not.
        /// </summary>
        [DataField("alwaysAllowed")]
        public bool AlwaysAllowed { get; private set; }
    }
}
