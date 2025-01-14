// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Chemistry.Components
{
    //TODO: refactor movement modifier component because this is a pretty poor solution
    [RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
    public sealed partial class MovespeedModifierMetabolismComponent : Component
    {
        [AutoNetworkedField, ViewVariables]
        public float WalkSpeedModifier { get; set; }

        [AutoNetworkedField, ViewVariables]
        public float SprintSpeedModifier { get; set; }

        /// <summary>
        /// When the current modifier is expected to end.
        /// </summary>
        [AutoNetworkedField, ViewVariables]
        public TimeSpan ModifierTimer { get; set; } = TimeSpan.Zero;
    }
}

