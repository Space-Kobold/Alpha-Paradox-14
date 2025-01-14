// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.Components;
using JetBrains.Annotations;

namespace Content.Server.Destructible.Thresholds.Behaviors
{
    /// <summary>
    ///     This behavior will trigger entities with <see cref="ExplosiveComponent"/> to go boom.
    /// </summary>
    [UsedImplicitly]
    [DataDefinition]
    public sealed partial class ExplodeBehavior : IThresholdBehavior
    {
        public void Execute(EntityUid owner, DestructibleSystem system, EntityUid? cause = null)
        {
            system.ExplosionSystem.TriggerExplosive(owner, user:cause);
        }
    }
}
