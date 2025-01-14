// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Network;

namespace Content.Server.Database;

public sealed class ServerRoleUnbanDef
{
    public int BanId { get; }

    public NetUserId? UnbanningAdmin { get; }

    public DateTimeOffset UnbanTime { get; }

    public ServerRoleUnbanDef(int banId, NetUserId? unbanningAdmin, DateTimeOffset unbanTime)
    {
        BanId = banId;
        UnbanningAdmin = unbanningAdmin;
        UnbanTime = unbanTime;
    }
}
