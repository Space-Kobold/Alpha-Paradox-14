// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Trinary.Components
{
    [RegisterComponent]
    public sealed partial class PressureControlledValveComponent : Component
    {
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("control")]
        public string ControlName { get; set; } = "control";

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

        [ViewVariables(VVAccess.ReadOnly)]
        [DataField("enabled")]
        public bool Enabled { get; set; } = false;

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("gain")]
        public float Gain { get; set; } = 10;

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("threshold")]
        public float Threshold { get; set; } = Atmospherics.OneAtmosphere;

        [DataField("maxTransferRate")]
        public float MaxTransferRate { get; set; } = Atmospherics.MaxTransferRate;
    }
}
