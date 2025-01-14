// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Globalization;
using Content.Server.Holiday.Interfaces;

namespace Content.Server.Holiday.ShouldCelebrate
{
    public sealed partial class ChineseNewYear : IHolidayShouldCelebrate
    {
        public bool ShouldCelebrate(DateTime date, HolidayPrototype holiday)
        {
            var chinese = new ChineseLunisolarCalendar();

            var chineseNewYear = chinese.ToDateTime(date.Year, 1, 1, 0, 0, 0, 0);

            return date.Day == chineseNewYear.Day && date.Month == chineseNewYear.Month;
        }
    }
}
