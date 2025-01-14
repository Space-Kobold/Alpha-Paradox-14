// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.EntitySystems;
using Content.Server.Anomaly.Components;
using Content.Shared.Anomaly.Components;

namespace Content.Server.Anomaly.Effects;

/// <summary>
/// This handles <see cref="ExplosionAnomalyComponent"/>
/// </summary>
public sealed class ExplosionAnomalySystem : EntitySystem
{
    [Dependency] private readonly ExplosionSystem _boom = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ExplosionAnomalyComponent, AnomalySupercriticalEvent>(OnSupercritical);
    }

    private void OnSupercritical(EntityUid uid, ExplosionAnomalyComponent component, ref AnomalySupercriticalEvent args)
    {
        _boom.QueueExplosion(
            uid,
            component.ExplosionPrototype,
            component.TotalIntensity,
            component.Dropoff,
            component.MaxTileIntensity
        );
    }
}
