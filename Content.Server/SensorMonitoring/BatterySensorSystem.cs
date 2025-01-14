// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceNetwork;
using Content.Server.DeviceNetwork.Systems;
using Content.Server.Power.Components;
using Content.Shared.DeviceNetwork;

namespace Content.Server.SensorMonitoring;

public sealed class BatterySensorSystem : EntitySystem
{
    public const string DeviceNetworkCommandSyncData = "bat_sync_data";

    [Dependency] private readonly DeviceNetworkSystem _deviceNetwork = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<BatterySensorComponent, DeviceNetworkPacketEvent>(PacketReceived);
    }

    private void PacketReceived(EntityUid uid, BatterySensorComponent component, DeviceNetworkPacketEvent args)
    {
        if (!args.Data.TryGetValue(DeviceNetworkConstants.Command, out string? cmd))
            return;

        switch (cmd)
        {
            case DeviceNetworkCommandSyncData:
                var battery = Comp<BatteryComponent>(uid);
                var netBattery = Comp<PowerNetworkBatteryComponent>(uid);

                var payload = new NetworkPayload
                {
                    [DeviceNetworkConstants.Command] = DeviceNetworkCommandSyncData,
                    [DeviceNetworkCommandSyncData] = new BatterySensorData(
                        battery.CurrentCharge,
                        battery.MaxCharge,
                        netBattery.CurrentReceiving,
                        netBattery.MaxChargeRate,
                        netBattery.CurrentSupply,
                        netBattery.MaxSupply)
                };

                _deviceNetwork.QueuePacket(uid, args.SenderAddress, payload);
                break;
        }
    }
}
