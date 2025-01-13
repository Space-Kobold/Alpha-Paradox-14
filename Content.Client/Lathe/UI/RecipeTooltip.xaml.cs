// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Message;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Lathe.UI;

[GenerateTypedNameReferences]
public sealed partial class RecipeTooltip : Control
{
    public RecipeTooltip(string tooltip)
    {
        RobustXamlLoader.Load(this);

        RecipeTooltipLabel.SetMarkup(tooltip);
    }
}
