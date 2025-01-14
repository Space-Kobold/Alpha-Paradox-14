// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceLinking.Events;
using Content.Server.DeviceLinking.Systems;
using Content.Server.Explosion.Components;

namespace Content.Server.Explosion.EntitySystems
{
    public sealed partial class TriggerSystem
    {
        [Dependency] private readonly DeviceLinkSystem _signalSystem = default!;
        private void InitializeSignal()
        {
            SubscribeLocalEvent<TriggerOnSignalComponent,SignalReceivedEvent>(OnSignalReceived);
            SubscribeLocalEvent<TriggerOnSignalComponent,ComponentInit>(OnInit);

            SubscribeLocalEvent<TimerStartOnSignalComponent,SignalReceivedEvent>(OnTimerSignalReceived);
            SubscribeLocalEvent<TimerStartOnSignalComponent,ComponentInit>(OnTimerSignalInit);
        }

        private void OnSignalReceived(EntityUid uid, TriggerOnSignalComponent component, ref SignalReceivedEvent args)
        {
            if (args.Port != component.Port)
                return;

            Trigger(uid, args.Trigger);
        }
        private void OnInit(EntityUid uid, TriggerOnSignalComponent component, ComponentInit args)
        {
            _signalSystem.EnsureSinkPorts(uid, component.Port);
        }

        private void OnTimerSignalReceived(EntityUid uid, TimerStartOnSignalComponent component, ref SignalReceivedEvent args)
        {
            if (args.Port != component.Port)
                return;

            StartTimer(uid, args.Trigger);
        }
        private void OnTimerSignalInit(EntityUid uid, TimerStartOnSignalComponent component, ComponentInit args)
        {
            _signalSystem.EnsureSinkPorts(uid, component.Port);
        }
    }
}
