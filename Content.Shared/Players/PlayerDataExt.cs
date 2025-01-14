// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Player;

namespace Content.Shared.Players;

public static class PlayerDataExt
{
    /// <summary>
    ///     Gets the correctly cast instance of content player data from an engine player data storage.
    /// </summary>
    public static ContentPlayerData? ContentData(this SessionData data)
    {
        return (ContentPlayerData?) data.ContentDataUncast;
    }

    /// <summary>
    ///     Gets the correctly cast instance of content player data from an engine player data storage.
    /// </summary>
    public static ContentPlayerData? ContentData(this ICommonSession session)
    {
        return session.Data.ContentData();
    }

    /// <summary>
    ///     Gets the mind that is associated with this player.
    /// </summary>
    public static EntityUid? GetMind(this ICommonSession session)
    {
        return session.Data.ContentData()?.Mind;
    }
}