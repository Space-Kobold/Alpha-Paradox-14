// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    ///     Whether or not world generation is enabled.
    /// </summary>
    public static readonly CVarDef<bool> WorldgenEnabled =
        CVarDef.Create("worldgen.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     The worldgen config to use.
    /// </summary>
    public static readonly CVarDef<string> WorldgenConfig =
        CVarDef.Create("worldgen.worldgen_config", "Default", CVar.SERVERONLY);
}
