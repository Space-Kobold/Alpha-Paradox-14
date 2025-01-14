// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Nutrition.EntitySystems;
using Content.Shared.Containers.ItemSlots;

namespace Content.Server.Nutrition.Components
{
    /// <summary>
    ///     A reusable vessel for smoking
    /// </summary>
    [RegisterComponent, Access(typeof(SmokingSystem))]
    public sealed partial class SmokingPipeComponent : Component
    {
        public const string BowlSlotId = "bowl_slot";

        [DataField("bowl_slot")]
        public ItemSlot BowlSlot = new();
    }
}
