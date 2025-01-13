// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Labels;
using Content.Shared.Labels.Components;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;

namespace Content.Client.Labels.UI
{
    /// <summary>
    /// Initializes a <see cref="HandLabelerWindow"/> and updates it when new server messages are received.
    /// </summary>
    public sealed class HandLabelerBoundUserInterface : BoundUserInterface
    {
        [Dependency] private readonly IEntityManager _entManager = default!;

        [ViewVariables]
        private HandLabelerWindow? _window;

        public HandLabelerBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
            IoCManager.InjectDependencies(this);
        }

        protected override void Open()
        {
            base.Open();

            _window = this.CreateWindow<HandLabelerWindow>();

            if (_entManager.TryGetComponent(Owner, out HandLabelerComponent? labeler))
            {
                _window.SetMaxLabelLength(labeler!.MaxLabelChars);
            }

            _window.OnLabelChanged += OnLabelChanged;
            Reload();
        }

        private void OnLabelChanged(string newLabel)
        {
            // Focus moment
            if (_entManager.TryGetComponent(Owner, out HandLabelerComponent? labeler) &&
                labeler.AssignedLabel.Equals(newLabel))
                return;

            SendPredictedMessage(new HandLabelerLabelChangedMessage(newLabel));
        }

        public void Reload()
        {
            if (_window == null || !_entManager.TryGetComponent(Owner, out HandLabelerComponent? component))
                return;

            _window.SetCurrentLabel(component.AssignedLabel);
        }
    }
}
