// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;
using Robust.Shared.Map;

// ReSharper disable once CheckNamespace
namespace Content.Shared.Chemistry.Reaction
{

    public sealed partial class ChemicalReactionSystem : EntitySystem
    {
        public FixedPoint2 ReactionTile(TileRef tile,
            ReagentDefinition reagent,
            FixedPoint2 reactVolume,
            IEntityManager entityManager,
            List<ReagentData>? data)
        {
            var removed = FixedPoint2.Zero;

            if (tile.Tile.IsEmpty)
                return removed;

            foreach (var reaction in reagent.TileReactions)
            {
                removed += reaction.TileReact(tile, reagent, reactVolume - removed, entityManager, data);

                if (removed > reactVolume)
                    throw new Exception("Removed more than we have!");

                if (removed == reactVolume)
                    break;
            }

            return removed;
        }
    }
}
