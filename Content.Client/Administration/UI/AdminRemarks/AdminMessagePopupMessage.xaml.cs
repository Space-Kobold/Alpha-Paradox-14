// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Administration.Notes;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.Administration.UI.AdminRemarks;

[GenerateTypedNameReferences]
public sealed partial class AdminMessagePopupMessage : Control
{
    public AdminMessagePopupMessage(AdminMessageEuiState.Message message)
    {
        RobustXamlLoader.Load(this);

        Admin.SetMessage(FormattedMessage.FromMarkupOrThrow(Loc.GetString(
            "admin-notes-message-admin",
            ("admin", message.AdminName),
            ("date", message.AddedOn.ToLocalTime()))));

        Message.SetMessage(message.Text);
    }
}
