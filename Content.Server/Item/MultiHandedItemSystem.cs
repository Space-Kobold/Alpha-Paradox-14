// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Hands.Systems;
using Content.Server.Inventory;
using Content.Shared.Hands;
using Content.Shared.Item;

namespace Content.Server.Item;

public sealed class MultiHandedItemSystem : SharedMultiHandedItemSystem
{
    [Dependency] private readonly VirtualItemSystem _virtualItem = default!;

    protected override void OnEquipped(EntityUid uid, MultiHandedItemComponent component, GotEquippedHandEvent args)
    {
        for (var i = 0; i < component.HandsNeeded - 1; i++)
        {
            _virtualItem.TrySpawnVirtualItemInHand(uid, args.User);
        }
    }

    protected override void OnUnequipped(EntityUid uid, MultiHandedItemComponent component, GotUnequippedHandEvent args)
    {
        _virtualItem.DeleteInHandsMatching(args.User, uid);
    }
}
