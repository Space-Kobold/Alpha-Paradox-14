// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Storage;
using Robust.Shared.Audio;

namespace Content.Server.Storage.Components
{
    /// <summary>
    ///     Spawns items when used in hand.
    /// </summary>
    [RegisterComponent]
    public sealed partial class SpawnItemsOnUseComponent : Component
    {
        /// <summary>
        ///     The list of entities to spawn, with amounts and orGroups.
        /// </summary>
        [DataField("items", required: true)]
        public List<EntitySpawnEntry> Items = new();

        /// <summary>
        ///     A sound to play when the items are spawned. For example, gift boxes being unwrapped.
        /// </summary>
        [DataField("sound")]
        public SoundSpecifier? Sound = null;

        /// <summary>
        ///     How many uses before the item should delete itself.
        /// </summary>
        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("uses")]
        public int Uses = 1;
    }
}
