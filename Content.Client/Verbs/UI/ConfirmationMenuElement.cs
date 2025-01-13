// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.ContextMenu.UI;
using Content.Shared.Verbs;
using Robust.Shared.Maths;
using Robust.Shared.Utility;

namespace Content.Client.Verbs.UI;

public sealed partial class ConfirmationMenuElement : ContextMenuElement
{
    public const string StyleClassConfirmationContextMenuButton = "confirmationContextMenuButton";

    public readonly Verb Verb;

    public override string Text
    {
        set
        {
            var message = new FormattedMessage();
            message.PushColor(Color.White);
            message.AddMarkupPermissive(value.Trim());
            Label.SetMessage(message);
        }
    }

    public ConfirmationMenuElement(Verb verb, string? text) : base(text)
    {
        Verb = verb;
        Icon.Visible = false;

        SetOnlyStyleClass(StyleClassConfirmationContextMenuButton);
    }
}
