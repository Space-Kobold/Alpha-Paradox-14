using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;
using Robust.Shared.Map;

namespace Content.Shared.Chemistry.Reaction
{
    public interface ITileReaction
    {
        FixedPoint2 TileReact(TileRef tile,
            ReagentDefinition reagent,
            FixedPoint2 reactVolume,
            IEntityManager entityManager,
            List<ReagentData>? data = null);
    }
}
