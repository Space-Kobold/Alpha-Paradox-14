// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Message;
using Content.Client.Stylesheets;
using Content.Shared.Tools.Components;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.Timing;

namespace Content.Client.Tools.Components
{
    public sealed class MultipleToolStatusControl : Control
    {
        private readonly MultipleToolComponent _parent;
        private readonly RichTextLabel _label;

        public MultipleToolStatusControl(MultipleToolComponent parent)
        {
            _parent = parent;
            _label = new RichTextLabel { StyleClasses = { StyleNano.StyleClassItemStatus } };
            _label.SetMarkup(_parent.StatusShowBehavior ? _parent.CurrentQualityName : string.Empty);
            AddChild(_label);
        }

        protected override void FrameUpdate(FrameEventArgs args)
        {
            base.FrameUpdate(args);

            if (_parent.UiUpdateNeeded)
            {
                _parent.UiUpdateNeeded = false;
                Update();
            }
        }

        public void Update()
        {
            _label.SetMarkup(_parent.StatusShowBehavior ? _parent.CurrentQualityName : string.Empty);
        }
    }
}
