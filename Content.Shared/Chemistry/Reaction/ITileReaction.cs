// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;
using Robust.Shared.Map;

namespace Content.Shared.Chemistry.Reaction
{
    public interface ITileReaction
    {
        FixedPoint2 TileReact(TileRef tile,
            ReagentPrototype reagent,
            FixedPoint2 reactVolume,
            IEntityManager entityManager,
            List<ReagentData>? data = null);
    }
}
