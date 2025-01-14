// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.GameTicking.Rules.Components;

/// <summary>
/// This is used for gamemodes that automatically respawn players when they're no longer alive.
/// </summary>
[RegisterComponent, Access(typeof(RespawnRuleSystem))]
public sealed partial class RespawnDeadRuleComponent : Component
{
    /// <summary>
    /// Whether or not we want to add everyone who dies to the respawn tracker
    /// </summary>
    [DataField]
    public bool AlwaysRespawnDead;
}
