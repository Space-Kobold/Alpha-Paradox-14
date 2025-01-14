// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Containers.ItemSlots;
using Content.Shared.Power.Components;

namespace Content.Shared.Power.EntitySystems;

public sealed class ItemSlotRequiresPowerSystem : EntitySystem
{
    [Dependency] private readonly SharedPowerReceiverSystem _receiver = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ItemSlotRequiresPowerComponent, ItemSlotInsertAttemptEvent>(OnInsertAttempt);
    }

    private void OnInsertAttempt(Entity<ItemSlotRequiresPowerComponent> ent, ref ItemSlotInsertAttemptEvent args)
    {
        if (!_receiver.IsPowered(ent.Owner))
        {
            args.Cancelled = true;
        }
    }
}
