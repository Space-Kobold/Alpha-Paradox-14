// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Power;
using Content.Shared.Whitelist;

namespace Content.Server.Power.Components
{
    [RegisterComponent]
    public sealed partial class ChargerComponent : Component
    {
        [ViewVariables]
        public CellChargerStatus Status;

        /// <summary>
        /// The charge rate of the charger, in watts
        /// </summary>
        [DataField("chargeRate")]
        public float ChargeRate = 20.0f;

        /// <summary>
        /// The container ID that is holds the entities being charged.
        /// </summary>
        [DataField("slotId", required: true)]
        public string SlotId = string.Empty;

        /// <summary>
        /// A whitelist for what entities can be charged by this Charger.
        /// </summary>
        [DataField("whitelist")]
        public EntityWhitelist? Whitelist;

        /// <summary>
        /// Indicates whether the charger is portable and thus subject to EMP effects
        /// and bypasses checks for transform, anchored, and ApcPowerReceiverComponent.
        /// </summary>
        [DataField]
        public bool Portable = false;
    }
}
