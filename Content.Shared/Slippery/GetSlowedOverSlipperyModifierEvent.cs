// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Inventory;

namespace Content.Shared.Slippery;
[ByRefEvent]
public record struct GetSlowedOverSlipperyModifierEvent() : IInventoryRelayEvent
{
    SlotFlags IInventoryRelayEvent.TargetSlots => ~SlotFlags.POCKET;

    public float SlowdownModifier = 1f;
}
