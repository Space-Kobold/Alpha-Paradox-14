// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Interaction
{
    public interface ITargetedInteractEventArgs
    {
        /// <summary>
        /// Performer of the attack
        /// </summary>
        EntityUid User { get; }
        /// <summary>
        /// Target of the attack
        /// </summary>
        EntityUid Target { get; }

    }
}
