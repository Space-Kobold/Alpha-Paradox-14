// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Threading.Tasks;
using Content.Server.Database;
using Content.Shared.Players.PlayTimeTracking;
using Robust.Shared.Network;

namespace Content.Server.Connection.Whitelist.Conditions;

/// <summary>
/// Condition that matches if the player has played for a certain amount of time.
/// </summary>
public sealed partial class ConditionPlaytime : WhitelistCondition
{
    [DataField]
    public int MinimumPlaytime = 0; // In minutes
}
