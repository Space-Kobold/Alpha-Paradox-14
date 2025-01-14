// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Temperature
{
    /// <summary>
    ///     Directed event raised on entities to query whether they're "hot" or not.
    ///     For example, a lit welder or matchstick would be hot, etc.
    /// </summary>
    public sealed class IsHotEvent : EntityEventArgs
    {
        public bool IsHot { get; set; } = false;
    }
}
