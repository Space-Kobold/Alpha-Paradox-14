// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Administration.Logs;
using Content.Shared.Database;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Administration.UI.CustomControls;

public sealed class AdminLogTypeButton : Button
{
    public AdminLogTypeButton(LogType type)
    {
        Type = type;
        ClipText = true;
        ToggleMode = true;
    }

    public LogType Type { get; }
}
