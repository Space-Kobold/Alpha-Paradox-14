// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Atmos;

namespace Content.Server.Atmos.Piping.Binary.Components
{
    [RegisterComponent]
    public sealed partial class GasPortComponent : Component
    {
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("pipe")]
        public string PipeName { get; set; } = "connected";

        [ViewVariables(VVAccess.ReadOnly)]
        public GasMixture Buffer { get; } = new();
    }
}
