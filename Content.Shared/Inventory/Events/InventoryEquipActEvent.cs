// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Inventory.Events;

/// <summary>
/// This event is used to tell the server-inventorysystem someone wants to equip something
/// </summary>
[NetSerializable, Serializable]
public sealed class InventoryEquipActEvent : EntityEventArgs
{
    public readonly NetEntity Uid;
    public readonly NetEntity ItemUid;
    public readonly string Slot;
    public readonly bool Silent;
    public readonly bool Force;

    public InventoryEquipActEvent(NetEntity uid, NetEntity itemUid, string slot, bool silent = false, bool force = false)
    {
        Uid = uid;
        ItemUid = itemUid;
        Slot = slot;
        Silent = silent;
        Force = force;
    }
}
