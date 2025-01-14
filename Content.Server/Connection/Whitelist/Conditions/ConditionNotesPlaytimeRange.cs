// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Database;

namespace Content.Server.Connection.Whitelist.Conditions;

/// <summary>
/// Condition that matches if the player has notes within a certain playtime range.
/// </summary>
public sealed partial class ConditionNotesPlaytimeRange : WhitelistCondition
{
    [DataField]
    public bool IncludeExpired = false;

    [DataField]
    public NoteSeverity MinimumSeverity  = NoteSeverity.Minor;

    /// <summary>
    /// The minimum number of notes required.
    /// </summary>
    [DataField]
    public int MinimumNotes = 1;

    /// <summary>
    /// The range in minutes to check for notes.
    /// </summary>
    [DataField]
    public int Range = int.MaxValue;

    [DataField]
    public bool IncludeSecret = false;
}
