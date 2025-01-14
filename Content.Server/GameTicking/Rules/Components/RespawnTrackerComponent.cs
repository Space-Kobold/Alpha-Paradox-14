// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Network;

namespace Content.Server.GameTicking.Rules.Components;

/// <summary>
/// This is used for globally tracking players that need to be respawned.
/// Used on gamerule entities.
/// </summary>
[RegisterComponent, Access(typeof(RespawnRuleSystem))]
public sealed partial class RespawnTrackerComponent : Component
{
    /// <summary>
    /// A list of the people that should be respawned.
    /// Used to make sure that we don't respawn aghosts or observers.
    /// </summary>
    [DataField]
    public HashSet<NetUserId> Players = new();

    /// <summary>
    /// The delay between dying and respawning.
    /// </summary>
    [DataField]
    public TimeSpan RespawnDelay = TimeSpan.Zero;

    /// <summary>
    /// A dictionary of player netuserids and when they will respawn.
    /// </summary>
    [DataField]
    public Dictionary<NetUserId, TimeSpan> RespawnQueue = new();

    /// <summary>
    /// Whether or not to delete the original body when respawning
    /// </summary>
    [DataField]
    public bool DeleteBody = true;
}
