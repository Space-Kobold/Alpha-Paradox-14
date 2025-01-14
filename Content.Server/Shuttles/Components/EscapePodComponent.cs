// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// If added to a grid gets launched when the emergency shuttle launches.
/// </summary>
[RegisterComponent, Access(typeof(EmergencyShuttleSystem)), AutoGenerateComponentPause]
public sealed partial class EscapePodComponent : Component
{
    [DataField(customTypeSerializer:typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan? LaunchTime;
}
