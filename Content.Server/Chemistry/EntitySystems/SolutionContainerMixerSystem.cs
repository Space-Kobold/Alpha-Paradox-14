// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.Components;
using Content.Server.Power.EntitySystems;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.EntitySystems;
using Content.Shared.Power;

namespace Content.Server.Chemistry.EntitySystems;

/// <inheritdoc/>
public sealed class SolutionContainerMixerSystem : SharedSolutionContainerMixerSystem
{
    /// <inheritdoc/>
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SolutionContainerMixerComponent, PowerChangedEvent>(OnPowerChanged);
    }

    private void OnPowerChanged(Entity<SolutionContainerMixerComponent> ent, ref PowerChangedEvent args)
    {
        if (!args.Powered)
            StopMix(ent);
    }

    protected override bool HasPower(Entity<SolutionContainerMixerComponent> entity)
    {
        return this.IsPowered(entity, EntityManager);
    }
}
