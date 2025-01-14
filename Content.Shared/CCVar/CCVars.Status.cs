// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    public static readonly CVarDef<string> StatusMoMMIUrl =
        CVarDef.Create("status.mommiurl", "", CVar.SERVERONLY);

    public static readonly CVarDef<string> StatusMoMMIPassword =
        CVarDef.Create("status.mommipassword", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

}
