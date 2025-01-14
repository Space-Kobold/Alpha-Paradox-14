// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Alert;
using Robust.Shared.GameStates;

namespace Content.Server.Alert;

internal sealed class ServerAlertsSystem : AlertsSystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AlertsComponent, ComponentGetState>(OnGetState);
    }

    private void OnGetState(Entity<AlertsComponent> alerts, ref ComponentGetState args)
    {
        args.State = new AlertComponentState(alerts.Comp.Alerts);
    }
}
