// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Stylesheets;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.UserInterface.Controls
{
    public sealed class NanoHeading : Container
    {
        private readonly Label _label;
        private readonly PanelContainer _panel;

        public NanoHeading()
        {
            _panel = new PanelContainer
            {
                Children = {(_label = new Label
                {
                    StyleClasses = {StyleNano.StyleClassLabelHeading}
                })}
            };
            AddChild(_panel);

            HorizontalAlignment = HAlignment.Left;
        }

        public string? Text
        {
            get => _label.Text;
            set => _label.Text = value;
        }
    }
}
