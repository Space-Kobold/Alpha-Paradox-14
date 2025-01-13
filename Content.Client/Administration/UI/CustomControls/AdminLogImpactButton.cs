// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Administration.Logs;
using Content.Shared.Database;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.Administration.UI.CustomControls;

public sealed class AdminLogImpactButton : Button
{
    public AdminLogImpactButton(LogImpact impact)
    {
        Impact = impact;
        ToggleMode = true;
        Pressed = true;
    }

    public LogImpact Impact { get; }
}
