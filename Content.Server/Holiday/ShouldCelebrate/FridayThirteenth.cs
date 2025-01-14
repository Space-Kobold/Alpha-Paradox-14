// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Holiday.Interfaces;
using JetBrains.Annotations;

namespace Content.Server.Holiday.ShouldCelebrate
{
    /// <summary>
    ///     For Friday the 13th. Spooky!
    /// </summary>
    [UsedImplicitly]
    public sealed partial class FridayThirteenth : IHolidayShouldCelebrate
    {
        public bool ShouldCelebrate(DateTime date, HolidayPrototype holiday)
        {
            return date.Day == 13 && date.DayOfWeek == DayOfWeek.Friday;
        }
    }
}
