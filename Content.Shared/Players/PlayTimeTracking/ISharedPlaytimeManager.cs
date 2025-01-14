// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Player;

namespace Content.Shared.Players.PlayTimeTracking;

public interface ISharedPlaytimeManager
{
    /// <summary>
    /// Gets the playtimes for the session or an empty dictionary if none found.
    /// </summary>
    IReadOnlyDictionary<string, TimeSpan> GetPlayTimes(ICommonSession session);
}

