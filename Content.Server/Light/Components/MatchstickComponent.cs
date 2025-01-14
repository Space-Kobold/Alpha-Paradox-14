// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Light.EntitySystems;
using Content.Shared.Smoking;
using Robust.Shared.Audio;

namespace Content.Server.Light.Components
{
    [RegisterComponent]
    [Access(typeof(MatchstickSystem))]
    public sealed partial class MatchstickComponent : Component
    {
        /// <summary>
        /// Current state to matchstick. Can be <code>Unlit</code>, <code>Lit</code> or <code>Burnt</code>.
        /// </summary>
        [DataField("state")]
        public SmokableState CurrentState = SmokableState.Unlit;

        /// <summary>
        /// How long will matchstick last in seconds.
        /// </summary>
        [ViewVariables(VVAccess.ReadOnly)]
        [DataField("duration")]
        public int Duration = 10;

        /// <summary>
        /// Sound played when you ignite the matchstick.
        /// </summary>
        [DataField("igniteSound", required: true)] public SoundSpecifier IgniteSound = default!;
    }
}
