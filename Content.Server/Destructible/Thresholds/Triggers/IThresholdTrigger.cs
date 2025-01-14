// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage;

namespace Content.Server.Destructible.Thresholds.Triggers
{
    public interface IThresholdTrigger
    {
        /// <summary>
        ///     Checks if this trigger has been reached.
        /// </summary>
        /// <param name="damageable">The damageable component to check with.</param>
        /// <param name="system">
        ///     An instance of <see cref="DestructibleSystem"/> to pull
        ///     dependencies from, if any.
        /// </param>
        /// <returns>true if this trigger has been reached, false otherwise.</returns>
        bool Reached(DamageableComponent damageable, DestructibleSystem system);
    }
}
