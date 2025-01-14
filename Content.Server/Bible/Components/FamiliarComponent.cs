// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Bible.Components
{
    /// <summary>
    /// This component is for the chaplain's familiars, and mostly
    /// used to track their current state and to give a component to check for
    /// if any special behavior is needed.
    /// </summary>
    [RegisterComponent]
    public sealed partial class FamiliarComponent : Component
    {
        /// <summary>
        /// The entity this familiar was summoned from.
        /// </summary>
        [ViewVariables]
        public EntityUid? Source = null;
    }
}
