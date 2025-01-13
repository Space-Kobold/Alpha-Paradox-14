// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Hands.UI
{
    public sealed class HandVirtualItemStatus : Control
    {
        public HandVirtualItemStatus()
        {
            RobustXamlLoader.Load(this);
        }
    }
}
