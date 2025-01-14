// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Holiday.Interfaces;
using JetBrains.Annotations;

namespace Content.Server.Holiday.Greet
{
    [UsedImplicitly]
    [DataDefinition]
    public sealed partial class Custom : IHolidayGreet
    {
        [DataField("text")] private string _greet = string.Empty;

        public string Greet(HolidayPrototype holiday)
        {
            return Loc.GetString(_greet);
        }
    }
}
