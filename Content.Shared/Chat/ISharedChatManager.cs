// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Chat;

public interface ISharedChatManager
{
    void Initialize();
    void SendAdminAlert(string message);
    void SendAdminAlert(EntityUid player, string message);
}
