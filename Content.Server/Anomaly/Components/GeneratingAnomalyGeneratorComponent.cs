// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Anomaly;
using Robust.Shared.Audio;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Anomaly.Components;

[RegisterComponent, Access(typeof(SharedAnomalySystem)), AutoGenerateComponentPause]
public sealed partial class GeneratingAnomalyGeneratorComponent : Component
{
    /// <summary>
    /// When the generating period will end.
    /// </summary>
    [DataField("endTime", customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan EndTime = TimeSpan.Zero;

    public EntityUid? AudioStream;
}
