// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Movement.Events
{
    /// <summary>
    /// Raised on an entity's parent when it has movement inputs while in a container.
    /// </summary>
    [ByRefEvent]
    public readonly struct ContainerRelayMovementEntityEvent
    {
        public readonly EntityUid Entity;

        public ContainerRelayMovementEntityEvent(EntityUid entity)
        {
            Entity = entity;
        }
    }
}
