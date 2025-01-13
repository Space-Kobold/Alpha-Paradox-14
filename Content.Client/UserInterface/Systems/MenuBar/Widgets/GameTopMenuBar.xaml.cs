// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.UserInterface.Systems.MenuBar.Widgets
{
    [GenerateTypedNameReferences]
    public sealed partial class GameTopMenuBar : UIWidget
    {
        public GameTopMenuBar()
        {
            RobustXamlLoader.Load(this);
        }
    }
}
