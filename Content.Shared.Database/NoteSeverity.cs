// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Database
{
    /// <summary>
    ///     Kinds of severity that a note can have
    /// </summary>
    public enum NoteSeverity
    {
        /// <summary>
        ///     No severity, displays a checkmark
        /// </summary>
        None = 0,

        /// <summary>
        ///     Minor severity, displays a minus
        /// </summary>
        Minor = 1,

        /// <summary>
        ///     Medium severity, displays one exclamation mark
        /// </summary>
        Medium = 2,

        /// <summary>
        ///     High severity, displays three exclamation marks
        /// </summary>
        High = 3,
    }
}
