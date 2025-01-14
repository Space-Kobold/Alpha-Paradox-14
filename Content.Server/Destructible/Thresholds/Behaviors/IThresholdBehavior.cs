// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Destructible.Thresholds.Behaviors
{
    public interface IThresholdBehavior
    {
        /// <summary>
        ///     Executes this behavior.
        /// </summary>
        /// <param name="owner">The entity that owns this behavior.</param>
        /// <param name="system">
        ///     An instance of <see cref="DestructibleSystem"/> to pull dependencies
        ///     and other systems from.
        /// </param>
        /// <param name="cause">The entity that caused this behavior.</param>
        void Execute(EntityUid owner, DestructibleSystem system, EntityUid? cause = null);
    }
}
