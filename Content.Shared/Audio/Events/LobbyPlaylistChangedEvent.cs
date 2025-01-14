// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Audio.Events;

/// <summary>
/// Event of changing lobby music playlist (on server).
/// </summary>
[Serializable, NetSerializable]
public sealed class LobbyPlaylistChangedEvent : EntityEventArgs
{
    /// <inheritdoc />
    public LobbyPlaylistChangedEvent(string[] playlist)
    {
        Playlist = playlist;
    }

    /// <summary>
    /// List of soundtrack filenames for lobby playlist.
    /// </summary>
    public string[] Playlist;
}

/// <summary>
/// Event of stopping lobby music.
/// </summary>
[Serializable, NetSerializable]
public sealed class LobbyMusicStopEvent : EntityEventArgs
{
}
