// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.CartridgeLoader.Cartridges;

[GenerateTypedNameReferences]
public sealed partial class LogProbeUiEntry : BoxContainer
{
    public LogProbeUiEntry(int numberLabel, string timeText, string accessorText)
    {
        RobustXamlLoader.Load(this);
        NumberLabel.Text = numberLabel.ToString();
        TimeLabel.Text = timeText;
        AccessorLabel.Text = accessorText;
    }
}
