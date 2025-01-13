// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Pinpointer;
using JetBrains.Annotations;
using Robust.Client.UserInterface;

namespace Content.Client.Pinpointer.UI;

[UsedImplicitly]
public sealed class NavMapBeaconBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private NavMapBeaconWindow? _window;

    public NavMapBeaconBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();
        _window = this.CreateWindow<NavMapBeaconWindow>();

        if (EntMan.TryGetComponent(Owner, out NavMapBeaconComponent? beacon))
        {
            _window.SetEntity(Owner, beacon);
        }

        _window.OnApplyButtonPressed += (label, enabled, color) =>
        {
            SendMessage(new NavMapBeaconConfigureBuiMessage(label, enabled, color));
        };
    }
}
