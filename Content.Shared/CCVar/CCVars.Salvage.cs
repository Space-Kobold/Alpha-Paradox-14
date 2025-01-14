// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    ///     Duration for missions
    /// </summary>
    public static readonly CVarDef<float>
        SalvageExpeditionDuration = CVarDef.Create("salvage.expedition_duration", 660f, CVar.REPLICATED);

    /// <summary>
    ///     Cooldown for missions.
    /// </summary>
    public static readonly CVarDef<float>
        SalvageExpeditionCooldown = CVarDef.Create("salvage.expedition_cooldown", 780f, CVar.REPLICATED);
}
