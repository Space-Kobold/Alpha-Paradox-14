// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Eye.Blinding.Components;
using Content.Shared.Inventory.Events;
using Content.Shared.Inventory;

namespace Content.Shared.Eye.Blinding.Systems;

public sealed class BlindfoldSystem : EntitySystem
{
    [Dependency] private readonly BlindableSystem _blindableSystem = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<BlindfoldComponent, GotEquippedEvent>(OnEquipped);
        SubscribeLocalEvent<BlindfoldComponent, GotUnequippedEvent>(OnUnequipped);
        SubscribeLocalEvent<BlindfoldComponent, InventoryRelayedEvent<CanSeeAttemptEvent>>(OnBlindfoldTrySee);
    }

    private void OnBlindfoldTrySee(Entity<BlindfoldComponent> blindfold, ref InventoryRelayedEvent<CanSeeAttemptEvent> args)
    {
        args.Args.Cancel();
    }

    private void OnEquipped(Entity<BlindfoldComponent> blindfold, ref GotEquippedEvent args)
    {
        _blindableSystem.UpdateIsBlind(args.Equipee);
    }

    private void OnUnequipped(Entity<BlindfoldComponent> blindfold, ref GotUnequippedEvent args)
    {
        _blindableSystem.UpdateIsBlind(args.Equipee);
    }
}
