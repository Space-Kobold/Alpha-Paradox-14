// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.UserInterface;
using Content.Shared.Crayon;
using Robust.Server.GameObjects;
using Robust.Shared.Audio;

namespace Content.Server.Crayon
{
    [RegisterComponent]
    public sealed partial class CrayonComponent : SharedCrayonComponent
    {
        [DataField("useSound")] public SoundSpecifier? UseSound;

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("selectableColor")]
        public bool SelectableColor { get; set; }

        [ViewVariables(VVAccess.ReadWrite)]
        public int Charges { get; set; }

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("capacity")]
        public int Capacity { get; set; } = 30;

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("deleteEmpty")]
        public bool DeleteEmpty = true;
    }
}
