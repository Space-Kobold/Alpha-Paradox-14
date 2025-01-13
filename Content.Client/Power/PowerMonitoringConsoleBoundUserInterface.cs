// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Power;
using Robust.Client.UserInterface;

namespace Content.Client.Power;

public sealed class PowerMonitoringConsoleBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private PowerMonitoringWindow? _menu;

    public PowerMonitoringConsoleBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey) { }

    protected override void Open()
    {
        _menu = this.CreateWindow<PowerMonitoringWindow>();
        _menu.SetEntity(Owner);
        _menu.SendPowerMonitoringConsoleMessageAction += SendPowerMonitoringConsoleMessage;
    }

    protected override void UpdateState(BoundUserInterfaceState state)
    {
        base.UpdateState(state);

        var castState = (PowerMonitoringConsoleBoundInterfaceState) state;

        EntMan.TryGetComponent<TransformComponent>(Owner, out var xform);
        _menu?.ShowEntites
            (castState.TotalSources,
            castState.TotalBatteryUsage,
            castState.TotalLoads,
            castState.AllEntries,
            castState.FocusSources,
            castState.FocusLoads,
            xform?.Coordinates);
    }

    public void SendPowerMonitoringConsoleMessage(NetEntity? netEntity, PowerMonitoringConsoleGroup group)
    {
        SendMessage(new PowerMonitoringConsoleMessage(netEntity, group));
    }
}
