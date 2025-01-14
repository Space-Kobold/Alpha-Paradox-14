// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Components;
using Content.Shared.Humanoid;
using Content.Shared.Objectives.Components;

namespace Content.Server.Objectives.Systems;

/// <summary>
/// Handles species requirement for objectives that require a certain species.
/// </summary>
public sealed class SpeciesRequirementSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SpeciesRequirementComponent, RequirementCheckEvent>(OnCheck);
    }

    private void OnCheck(Entity<SpeciesRequirementComponent> requirement, ref RequirementCheckEvent args)
    {
        if (args.Cancelled)
            return;

        if (!TryComp<HumanoidAppearanceComponent>(args.Mind.OwnedEntity, out var appearance)) {
            args.Cancelled = true;
            return;
        }
        if (!requirement.Comp.AllowedSpecies.Contains(appearance.Species))
        {
            args.Cancelled = true;
            return;
        }
    }
}
