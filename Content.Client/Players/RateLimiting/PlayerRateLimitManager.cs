// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Players.RateLimiting;
using Robust.Shared.Player;

namespace Content.Client.Players.RateLimiting;

public sealed class PlayerRateLimitManager : SharedPlayerRateLimitManager
{
    public override RateLimitStatus CountAction(ICommonSession player, string key)
    {
        // TODO Rate-Limit
        // Add support for rate limit prediction
        // I.e., dont mis-predict just because somebody is clicking too quickly.
        return RateLimitStatus.Allowed;
    }

    public override void Register(string key, RateLimitRegistration registration)
    {
    }

    public override void Initialize()
    {
    }
}
