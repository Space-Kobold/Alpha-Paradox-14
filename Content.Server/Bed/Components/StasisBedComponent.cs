// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Bed.Components
{
    [RegisterComponent]
    public sealed partial class StasisBedComponent : Component
    {
        /// <summary>
        /// What the metabolic update rate will be multiplied by (higher = slower metabolism)
        /// </summary>
        [ViewVariables(VVAccess.ReadOnly)] // Writing is is not supported. ApplyMetabolicMultiplierEvent needs to be refactored first
        [DataField]
        public float Multiplier = 10f;
    }
}
