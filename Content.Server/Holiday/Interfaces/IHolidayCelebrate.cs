// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Holiday.Interfaces
{
    public interface IHolidayCelebrate
    {
        /// <summary>
        ///     This method is called before a round starts.
        ///     Use it to do any fun festive modifications.
        /// </summary>
        void Celebrate(HolidayPrototype holiday);
    }
}
