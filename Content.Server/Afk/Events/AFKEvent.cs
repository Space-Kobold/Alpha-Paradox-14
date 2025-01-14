// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Player;

namespace Content.Server.Afk.Events;

/// <summary>
/// Raised whenever a player goes afk.
/// </summary>
[ByRefEvent]
public readonly struct AFKEvent
{
    public readonly ICommonSession Session;

    public AFKEvent(ICommonSession playerSession)
    {
        Session = playerSession;
    }
}
