// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceLinking.Systems;
using Content.Server.Shuttles.Components;
using Content.Server.Shuttles.Events;

namespace Content.Server.Shuttles.Systems;

public sealed class DockingSignalControlSystem : EntitySystem
{
    [Dependency] private readonly DeviceLinkSystem _deviceLinkSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<DockingSignalControlComponent, DockEvent>(OnDocked);
        SubscribeLocalEvent<DockingSignalControlComponent, UndockEvent>(OnUndocked);
    }

    private void OnDocked(Entity<DockingSignalControlComponent> ent, ref DockEvent args)
    {
        _deviceLinkSystem.SendSignal(ent, ent.Comp.DockStatusSignalPort, signal: true);
    }

    private void OnUndocked(Entity<DockingSignalControlComponent> ent, ref UndockEvent args)
    {
        _deviceLinkSystem.SendSignal(ent, ent.Comp.DockStatusSignalPort, signal: false);
    }
}
