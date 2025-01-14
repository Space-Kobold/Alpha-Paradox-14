// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.FixedPoint;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components
{
    // TODO It'd be nice if this could be a destructible threshold, but on the other hand,
    // that doesn't really work with events at all, and
    [RegisterComponent, NetworkedComponent]
    public sealed partial class SlowOnDamageComponent : Component
    {
        /// <summary>
        ///     Damage -> movespeed dictionary. This is -damage-, not -health-.
        /// </summary>
        [DataField("speedModifierThresholds", required: true)]
        public Dictionary<FixedPoint2, float> SpeedModifierThresholds = default!;
    }
}
