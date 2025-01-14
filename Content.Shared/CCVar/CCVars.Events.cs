// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    ///     Controls if the game should run station events
    /// </summary>
    public static readonly CVarDef<bool>
        EventsEnabled = CVarDef.Create("events.enabled", true, CVar.ARCHIVE | CVar.SERVERONLY);
}
