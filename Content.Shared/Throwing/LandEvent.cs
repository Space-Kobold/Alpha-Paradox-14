// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Throwing
{
    /// <summary>
    ///     Raised when an entity that was thrown lands. This occurs before they stop moving and is when their tile-friction is reapplied.
    /// </summary>
    [ByRefEvent]
    public readonly record struct LandEvent(EntityUid? User, bool PlaySound);

    /// <summary>
    /// Raised when a thrown entity is no longer moving.
    /// </summary>
    public sealed class StopThrowEvent : EntityEventArgs
    {
        public EntityUid? User;
    }
}
