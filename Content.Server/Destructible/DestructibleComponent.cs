// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Destructible.Thresholds;

namespace Content.Server.Destructible
{
    /// <summary>
    ///     When attached to an <see cref="Robust.Shared.GameObjects.EntityUid"/>, allows it to take damage
    ///     and triggers thresholds when reached.
    /// </summary>
    [RegisterComponent]
    public sealed partial class DestructibleComponent : Component
    {
        [DataField("thresholds")]
        public List<DamageThreshold> Thresholds = new();

    }
}
