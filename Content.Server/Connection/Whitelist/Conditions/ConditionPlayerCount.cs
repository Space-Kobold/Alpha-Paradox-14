// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Threading.Tasks;
using Robust.Server.Player;
using Robust.Shared.Network;

namespace Content.Server.Connection.Whitelist.Conditions;

/// <summary>
/// Condition that matches if the player count is within a certain range.
/// </summary>
public sealed partial class ConditionPlayerCount : WhitelistCondition
{
    [DataField]
    public int MinimumPlayers  = 0;
    [DataField]
    public int MaximumPlayers = int.MaxValue;
}
