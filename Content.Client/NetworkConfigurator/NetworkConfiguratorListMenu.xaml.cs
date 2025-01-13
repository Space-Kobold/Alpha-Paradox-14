// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.UserInterface.Controls;
using Content.Shared.DeviceNetwork;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.NetworkConfigurator;

[GenerateTypedNameReferences]
public sealed partial class NetworkConfiguratorListMenu : FancyWindow
{
    public event Action<string>? OnRemoveAddress;

    public NetworkConfiguratorListMenu()
    {
        RobustXamlLoader.Load(this);
        DeviceList.OnRemoveAddress += args =>
        {
            OnRemoveAddress?.Invoke(args);
        };
    }

    public void UpdateState(NetworkConfiguratorUserInterfaceState state)
    {
        DeviceCountLabel.Text = Loc.GetString("network-configurator-ui-count-label", ("count", state.DeviceList.Count));
        DeviceList.UpdateState(state.DeviceList, true);
    }
}
