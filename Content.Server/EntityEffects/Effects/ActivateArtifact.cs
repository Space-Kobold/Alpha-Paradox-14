// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Xenoarchaeology.XenoArtifacts;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Prototypes;
using Content.Shared.EntityEffects;

namespace Content.Server.EntityEffects.Effects;

public sealed partial class ActivateArtifact : EntityEffect
{
    public override void Effect(EntityEffectBaseArgs args)
    {
        var artifact = args.EntityManager.EntitySysManager.GetEntitySystem<ArtifactSystem>();
        artifact.TryActivateArtifact(args.TargetEntity, logMissing: false);
    }

    protected override string? ReagentEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys) =>
        Loc.GetString("reagent-effect-guidebook-activate-artifact", ("chance", Probability));
}
