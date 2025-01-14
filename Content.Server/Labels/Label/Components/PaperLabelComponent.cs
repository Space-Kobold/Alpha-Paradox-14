// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Containers.ItemSlots;

namespace Content.Server.Labels.Components
{
    /// <summary>
    ///     This component allows you to attach and remove a piece of paper to an entity.
    /// </summary>
    [RegisterComponent]
    public sealed partial class PaperLabelComponent : Component
    {
        [DataField("labelSlot")]
        public ItemSlot LabelSlot = new();
    }
}
