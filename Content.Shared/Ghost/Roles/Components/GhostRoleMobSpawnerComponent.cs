// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Ghost.Roles.Components
{
    /// <summary>
    ///     Allows a ghost to take this role, spawning a new entity.
    /// </summary>
    [RegisterComponent, EntityCategory("Spawner")]
    public sealed partial class GhostRoleMobSpawnerComponent : Component
    {
        [DataField]
        public bool DeleteOnSpawn = true;

        [DataField]
        public int AvailableTakeovers = 1;

        [ViewVariables]
        public int CurrentTakeovers = 0;

        [DataField]
        public EntProtoId? Prototype;

        /// <summary>
        ///     If this ghostrole spawner has multiple selectable ghostrole prototypes.
        /// </summary>
        [DataField]
        public List<string> SelectablePrototypes = [];
    }
}
