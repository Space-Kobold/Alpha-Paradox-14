// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Hands.Components;
using Content.Shared.Movement.Systems;

namespace Content.Shared.Hands.EntitySystems;

public abstract partial class SharedHandsSystem
{
    private void InitializeRelay()
    {
        SubscribeLocalEvent<HandsComponent, RefreshMovementSpeedModifiersEvent>(RelayEvent);
    }

    private void RelayEvent<T>(Entity<HandsComponent> entity, ref T args) where T : EntityEventArgs
    {
        var ev = new HeldRelayedEvent<T>(args);
        foreach (var held in EnumerateHeld(entity, entity.Comp))
        {
            RaiseLocalEvent(held, ref ev);
        }
    }
}
