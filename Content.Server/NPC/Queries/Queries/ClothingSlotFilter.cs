// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Inventory;

namespace Content.Server.NPC.Queries.Queries;

public sealed partial class ClothingSlotFilter : UtilityQueryFilter
{
    [DataField("slotFlags", required: true)]
    public SlotFlags SlotFlags = SlotFlags.NONE;
}
