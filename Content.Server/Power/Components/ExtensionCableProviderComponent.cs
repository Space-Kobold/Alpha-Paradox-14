// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.EntitySystems;

namespace Content.Server.Power.Components
{
    [RegisterComponent]
    [Access(typeof(ExtensionCableSystem))]
    public sealed partial class ExtensionCableProviderComponent : Component
    {
        /// <summary>
        ///     The max distance this can connect to <see cref="ExtensionCableReceiverComponent"/>s from.
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("transferRange")]
        public int TransferRange { get; set; } = 3;

        [ViewVariables] public List<ExtensionCableReceiverComponent> LinkedReceivers { get; } = new();

        /// <summary>
        ///     If <see cref="ExtensionCableReceiverComponent"/>s should consider connecting to this.
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        public bool Connectable { get; set; } = true;


    }
}
