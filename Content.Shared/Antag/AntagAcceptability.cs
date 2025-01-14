// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Antag;

/// <summary>
/// Used by AntagSelectionSystem to indicate which types of antag roles are allowed to choose the same entity
/// For example, Thief HeadRev
/// </summary>
public enum AntagAcceptability
{
    /// <summary>
    /// Dont choose anyone who already has an antag role
    /// </summary>
    None,
    /// <summary>
    /// Dont choose anyone who has an exclusive antag role
    /// </summary>
    NotExclusive,
    /// <summary>
    /// Choose anyone
    /// </summary>
    All
}

public enum AntagSelectionTime : byte
{
    /// <summary>
    /// Antag roles are assigned before players are assigned jobs and spawned in.
    /// This prevents antag selection from happening if the round is on-going.
    /// </summary>
    PrePlayerSpawn,

    /// <summary>
    /// Antag roles get assigned after players have been assigned jobs and have spawned in.
    /// </summary>
    PostPlayerSpawn
}
