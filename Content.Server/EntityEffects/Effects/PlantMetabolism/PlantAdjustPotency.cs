// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Botany.Systems;
using Content.Shared.EntityEffects;

namespace Content.Server.EntityEffects.Effects.PlantMetabolism;

/// <summary>
///     Handles increase or decrease of plant potency.
/// </summary>

public sealed partial class PlantAdjustPotency : PlantAdjustAttribute
{
    public override string GuidebookAttributeName { get; set; } = "plant-attribute-potency";

    public override void Effect(EntityEffectBaseArgs args)
    {
        if (!CanMetabolize(args.TargetEntity, out var plantHolderComp, args.EntityManager))
            return;

        if (plantHolderComp.Seed == null)
            return;

        var plantHolder = args.EntityManager.System<PlantHolderSystem>();

        plantHolder.EnsureUniqueSeed(args.TargetEntity, plantHolderComp);

        plantHolderComp.Seed.Potency = Math.Max(plantHolderComp.Seed.Potency + Amount, 1);
    }
}
