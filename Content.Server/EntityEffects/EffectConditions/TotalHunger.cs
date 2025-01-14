// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.EntityEffects;
using Content.Shared.Nutrition.Components;
using Content.Shared.Nutrition.EntitySystems;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.EffectConditions;

public sealed partial class Hunger : EntityEffectCondition
{
    [DataField]
    public float Max = float.PositiveInfinity;

    [DataField]
    public float Min = 0;

    public override bool Condition(EntityEffectBaseArgs args)
    {
        if (args.EntityManager.TryGetComponent(args.TargetEntity, out HungerComponent? hunger))
        {
            var total = args.EntityManager.System<HungerSystem>().GetHunger(hunger);
            if (total > Min && total < Max)
                return true;
        }

        return false;
    }

    public override string GuidebookExplanation(IPrototypeManager prototype)
    {
        return Loc.GetString("reagent-effect-condition-guidebook-total-hunger",
            ("max", float.IsPositiveInfinity(Max) ? (float) int.MaxValue : Max),
            ("min", Min));
    }
}
