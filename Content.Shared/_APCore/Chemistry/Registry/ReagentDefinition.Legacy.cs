// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared.Chemistry.Reagent;

namespace Content.Shared._APCore.Chemistry.Registry;

public partial class ReagentDefinition
{
    public static implicit operator ReagentDefinition(ReagentPrototype old)
    {
        return new ReagentDefinition
        {
            Id = old.ID,
            Name = old.Name,
            Description = old.Description,
            Group = old.Group,
            PhysicalDescription = old.PhysicalDescription,
            Recognizable = old.Recognizable,
            Flavor = old.Flavor,
            FlavorMinimum = old.FlavorMinimum,
            SubstanceColor = old.SubstanceColor,
            SpecificHeat = old.SpecificHeat,
            BoilingPoint = old.BoilingPoint,
            MeltingPoint = old.MeltingPoint,
            MetamorphicSprite = old.MetamorphicSprite,
            MetamorphicMaxFillLevels = old.MetamorphicMaxFillLevels,
            MetamorphicChangeColor = old.MetamorphicChangeColor,
            Slippery = old.Slippery,
            Fizziness = old.Fizziness,
            Viscosity = old.Viscosity,
            WorksOnTheDead = old.WorksOnTheDead,
            Metabolisms = old.Metabolisms,
            ReactiveEffects = old.ReactiveEffects,
            TileReactions = old.TileReactions,
            PlantMetabolisms = old.PlantMetabolisms,
            PricePerUnit = old.PricePerUnit,
            FootstepSound = old.FootstepSound
        };
    }
}
