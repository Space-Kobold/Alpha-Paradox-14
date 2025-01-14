// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Anomaly.Components;

/// <summary>
/// This component tracks anomalies that are currently pulsing
/// </summary>
[RegisterComponent, Access(typeof(SharedAnomalySystem)), AutoGenerateComponentPause]
public sealed partial class AnomalyPulsingComponent : Component
{
    /// <summary>
    /// The time at which the pulse will be over.
    /// </summary>
    [DataField("endTime", customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    [AutoPausedField]
    public TimeSpan EndTime;

    /// <summary>
    /// How long the pulse visual lasts
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan PulseDuration = TimeSpan.FromSeconds(5);
}
