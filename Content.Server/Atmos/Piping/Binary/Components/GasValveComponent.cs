// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Server.Atmos.Piping.Binary.Components
{
    [RegisterComponent]
    public sealed partial class GasValveComponent : Component
    {
        [DataField("open")]
        public bool Open { get; set; } = true;

        [DataField("inlet")]
        public string InletName { get; set; } = "inlet";

        [DataField("outlet")]
        public string OutletName { get; set; } = "outlet";

        [DataField("valveSound")]
        public SoundSpecifier ValveSound { get; private set; } = new SoundCollectionSpecifier("valveSqueak");
    }
}
