// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Threading;

namespace Content.Server.GameTicking.Rules.Components;

/// <summary>
/// Gamerule that ends the round after a period of inactivity.
/// </summary>
[RegisterComponent, Access(typeof(InactivityTimeRestartRuleSystem))]
public sealed partial class InactivityRuleComponent : Component
{
    /// <summary>
    /// How long the round must be inactive to restart
    /// </summary>
    [DataField("inactivityMaxTime", required: true)]
    public TimeSpan InactivityMaxTime = TimeSpan.FromMinutes(10);

    /// <summary>
    /// The delay between announcing round end and the lobby.
    /// </summary>
    [DataField("roundEndDelay", required: true)]
    public TimeSpan RoundEndDelay  = TimeSpan.FromSeconds(10);

    public CancellationTokenSource TimerCancel = new();
}
