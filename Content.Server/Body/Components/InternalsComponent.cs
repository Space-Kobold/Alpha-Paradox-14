// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Alert;
using Robust.Shared.Prototypes;

namespace Content.Server.Body.Components
{
    /// <summary>
    /// Handles hooking up a mask (breathing tool) / gas tank together and allowing the Owner to breathe through it.
    /// </summary>
    [RegisterComponent]
    public sealed partial class InternalsComponent : Component
    {
        [ViewVariables]
        public EntityUid? GasTankEntity;

        [ViewVariables]
        public HashSet<EntityUid> BreathTools { get; set; } = new();

        /// <summary>
        /// Toggle Internals delay when the target is not you.
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField]
        public TimeSpan Delay = TimeSpan.FromSeconds(3);

        [DataField]
        public ProtoId<AlertPrototype> InternalsAlert = "Internals";
    }

}
