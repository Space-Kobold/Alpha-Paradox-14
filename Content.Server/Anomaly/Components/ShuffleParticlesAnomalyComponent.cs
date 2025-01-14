// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Anomaly.Effects;

namespace Content.Server.Anomaly.Components;

/// <summary>
/// Shuffle Particle types in some situations
/// </summary>
[RegisterComponent, Access(typeof(ShuffleParticlesAnomalySystem))]
public sealed partial class ShuffleParticlesAnomalyComponent : Component
{
    /// <summary>
    /// Prob() chance to randomize particle types after Anomaly pulation
    /// </summary>
    [DataField]
    public bool ShuffleOnPulse = false;

    /// <summary>
    /// Prob() chance to randomize particle types after APE or CHIMP projectile
    /// </summary>
    [DataField]
    public bool ShuffleOnParticleHit = false;

    /// <summary>
    /// Chance to random particles
    /// </summary>
    [DataField]
    public float Prob = 0.5f;
}
