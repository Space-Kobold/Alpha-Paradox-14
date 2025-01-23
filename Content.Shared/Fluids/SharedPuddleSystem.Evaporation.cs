using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Reagent;
using ReagentId = Content.Shared._APCore.Chemistry.Reagents.ReagentId;

namespace Content.Shared.Fluids;

public abstract partial class SharedPuddleSystem
{
    private static readonly ReagentId Water = "Water";

    public static readonly string[] EvaporationReagents = [Water];

    public bool CanFullyEvaporate(Solution solution)
    {
        return solution.GetTotalPrototypeQuantity(EvaporationReagents) == solution.Volume;
    }
}
