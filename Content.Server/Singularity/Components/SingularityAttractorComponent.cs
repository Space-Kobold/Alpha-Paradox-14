// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Singularity.EntitySystems;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Singularity.Components;

/// <summary>
/// Attracts the singularity.
/// </summary>
[RegisterComponent]
[Access(typeof(SingularityAttractorSystem))]
public sealed partial class SingularityAttractorComponent : Component
{
    /// <summary>
    /// The range at which singularities will be unable to go away from the attractor.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float BaseRange = 25f;

    /// <summary>
    /// The amount of time that should elapse between pulses of this attractor.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadOnly)]
    public TimeSpan TargetPulsePeriod = TimeSpan.FromSeconds(2);

    /// <summary>
    /// The last time this attractor pulsed.
    /// </summary>
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    public TimeSpan LastPulseTime = default!;
}
