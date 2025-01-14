// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared.Chemistry.Reaction;
using Serilog;

namespace Content.Shared._APCore.Chemistry.Registry;

public sealed partial class ReactionDefinition
{

    public static implicit operator ReactionDefinition(ReactionPrototype old)
    {
         Dictionary<string, Reactant> newData = new();
         foreach (var (key, data) in old.Reactants)
         {
             newData.Add(key, new Reactant(data.Amount,data.Catalyst));
         }
         return new ReactionDefinition
         {
             Id = old.ID,
             Name = old.Name,
             Reactants = newData,
             MinimumTemperature = old.MinimumTemperature,
             ConserveEnergy = old.ConserveEnergy,
             MaximumTemperature = old.MaximumTemperature,
             MixingCategories = old.MixingCategories,
             Effects = old.Effects,
             Impact = old.Impact,
             Sound = old.Sound,
             Quantized = old.Quantized,
             Priority = old.Priority,
             Source = old.Source
         };
    }
}
