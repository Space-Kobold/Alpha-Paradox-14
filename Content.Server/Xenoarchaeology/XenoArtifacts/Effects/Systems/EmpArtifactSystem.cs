// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Emp;
using Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;
using Content.Server.Xenoarchaeology.XenoArtifacts.Events;
using Robust.Server.GameObjects;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Systems;

public sealed class EmpArtifactSystem : EntitySystem
{
    [Dependency] private readonly EmpSystem _emp = default!;
    [Dependency] private readonly TransformSystem _transform = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
        SubscribeLocalEvent<EmpArtifactComponent, ArtifactActivatedEvent>(OnActivate);
    }

    private void OnActivate(EntityUid uid, EmpArtifactComponent component, ArtifactActivatedEvent args)
    {
        _emp.EmpPulse(_transform.GetMapCoordinates(uid), component.Range, component.EnergyConsumption, component.DisableDuration);
    }
}
