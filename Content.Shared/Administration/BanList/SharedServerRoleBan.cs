// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Shared.Administration.BanList;

[Serializable, NetSerializable]
public sealed record SharedServerRoleBan(
    int? Id,
    NetUserId? UserId,
    (string address, int cidrMask)? Address,
    string? HWId,
    DateTime BanTime,
    DateTime? ExpirationTime,
    string Reason,
    string? BanningAdminName,
    SharedServerUnban? Unban,
    string Role
) : SharedServerBan(Id, UserId, Address, HWId, BanTime, ExpirationTime, Reason, BanningAdminName, Unban);
