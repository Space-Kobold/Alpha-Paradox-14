// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Utility;

namespace Content.Client.Info;

[GenerateTypedNameReferences]
public sealed partial class InfoSection : BoxContainer
{
    public InfoSection(string title, string text, bool markup = false)
    {
        RobustXamlLoader.Load(this);
        SetText(title, text, markup);
    }

    public void SetText(string title, string text, bool markup = false)
    {
        TitleLabel.Text = title;
        if (markup)
            Content.SetMessage(FormattedMessage.FromMarkupOrThrow(text.Trim()));
        else
            Content.SetMessage(text);
    }
}
