// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Ghost.Roles.Events
{
    /// <summary>
    /// Raised on a spawned entity after they use a ghost role mob spawner.
    /// </summary>
    public sealed class GhostRoleSpawnerUsedEvent : EntityEventArgs
    {
        /// <summary>
        /// The entity that spawned this.
        /// </summary>
        public EntityUid Spawner;

        /// <summary>
        /// The entity spawned.
        /// </summary>
        public EntityUid Spawned;

        public GhostRoleSpawnerUsedEvent(EntityUid spawner, EntityUid spawned)
        {
            Spawner = spawner;

            Spawned = spawned;
        }
    }
}
