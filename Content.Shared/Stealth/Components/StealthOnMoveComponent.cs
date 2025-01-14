// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Stealth.Components
{
    /// <summary>
    ///     When added to an entity with stealth component, this component will change the visibility
    ///     based on the entity's (lack of) movement.
    /// </summary>
    [RegisterComponent, NetworkedComponent]
    public sealed partial class StealthOnMoveComponent : Component
    {
        /// <summary>
        /// Rate that effects how fast an entity's visibility passively changes.
        /// </summary>
        [DataField("passiveVisibilityRate")]
        public float PassiveVisibilityRate = -0.15f;

        /// <summary>
        /// Rate for movement induced visibility changes. Scales with distance moved.
        /// </summary>
        [DataField("movementVisibilityRate")]
        public float MovementVisibilityRate = 0.2f;
    }
}
