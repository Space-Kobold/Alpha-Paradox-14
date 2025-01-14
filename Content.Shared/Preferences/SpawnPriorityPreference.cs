// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Preferences
{
    /// <summary>
    /// The spawn priority preference for a profile. Stored in database!
    /// </summary>
    public enum SpawnPriorityPreference
    {
        ///////////////////////
        /// DO NOT TOUCH!!! ///
        ///////////////////////
        None = 0,
        Arrivals = 1,
        Cryosleep = 2,
    }
}
