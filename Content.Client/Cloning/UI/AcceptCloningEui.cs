// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Eui;
using Content.Shared.Cloning;
using JetBrains.Annotations;
using Robust.Client.Graphics;

namespace Content.Client.Cloning.UI
{
    [UsedImplicitly]
    public sealed class AcceptCloningEui : BaseEui
    {
        private readonly AcceptCloningWindow _window;

        public AcceptCloningEui()
        {
            _window = new AcceptCloningWindow();

            _window.DenyButton.OnPressed += _ =>
            {
                SendMessage(new AcceptCloningChoiceMessage(AcceptCloningUiButton.Deny));
                _window.Close();
            };

            _window.OnClose += () => SendMessage(new AcceptCloningChoiceMessage(AcceptCloningUiButton.Deny));

            _window.AcceptButton.OnPressed += _ =>
            {
                SendMessage(new AcceptCloningChoiceMessage(AcceptCloningUiButton.Accept));
                _window.Close();
            };
        }

        public override void Opened()
        {
            IoCManager.Resolve<IClyde>().RequestWindowAttention();
            _window.OpenCentered();
        }

        public override void Closed()
        {
            _window.Close();
        }

    }
}
