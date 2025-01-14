// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    ///     The time you must spend reading the rules, before the "Request" button is enabled
    /// </summary>
    public static readonly CVarDef<float> GhostRoleTime =
        CVarDef.Create("ghost.role_time", 3f, CVar.REPLICATED | CVar.SERVER);

    /// <summary>
    ///     If ghost role lotteries should be made near-instanteous.
    /// </summary>
    public static readonly CVarDef<bool> GhostQuickLottery =
        CVarDef.Create("ghost.quick_lottery", false, CVar.SERVERONLY);

    /// <summary>
    ///     Whether or not to kill the player's mob on ghosting, when it is in a critical health state.
    /// </summary>
    public static readonly CVarDef<bool> GhostKillCrit =
        CVarDef.Create("ghost.kill_crit", true, CVar.REPLICATED | CVar.SERVER);
}
