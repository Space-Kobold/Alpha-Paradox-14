// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Inventory.Events;

public sealed class RefreshEquipmentHudEvent<T> : EntityEventArgs, IInventoryRelayEvent where T : IComponent
{
    public SlotFlags TargetSlots { get; init; }
    public bool Active = false;
    public List<T> Components = new();

    public RefreshEquipmentHudEvent(SlotFlags targetSlots)
    {
        TargetSlots = targetSlots;
    }
}
