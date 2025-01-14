// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Holiday.Interfaces;

namespace Content.Server.Holiday.Greet
{
    [DataDefinition]
    public sealed partial class DefaultHolidayGreet : IHolidayGreet
    {
        public string Greet(HolidayPrototype holiday)
        {
            var holidayName = Loc.GetString(holiday.Name);
            return Loc.GetString("holiday-greet", ("holidayName", holidayName));
        }
    }
}
