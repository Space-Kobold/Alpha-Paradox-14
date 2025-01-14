// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.EntitySystems;

namespace Content.Server.Power.Components
{
    [RegisterComponent]
    [Access(typeof(ExtensionCableSystem))]
    public sealed partial class ExtensionCableReceiverComponent : Component
    {
        [ViewVariables]
        public ExtensionCableProviderComponent? Provider { get; set; }

        [ViewVariables]
        public bool Connectable = false;

        /// <summary>
        ///     The max distance from a <see cref="ExtensionCableProviderComponent"/> that this can receive power from.
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("receptionRange")]
        public int ReceptionRange { get; set; } = 3;
    }
}
