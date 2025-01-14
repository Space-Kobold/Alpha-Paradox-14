// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Medical.SuitSensor;
using Robust.Shared.Map;

namespace Content.Server.Medical.CrewMonitoring;

[RegisterComponent]
[Access(typeof(CrewMonitoringServerSystem))]
public sealed partial class CrewMonitoringServerComponent : Component
{

    /// <summary>
    ///     List of all currently connected sensors to this server.
    /// </summary>
    public readonly Dictionary<string, SuitSensorStatus> SensorStatus = new();

    /// <summary>
    ///     After what time sensor consider to be lost.
    /// </summary>
    [DataField("sensorTimeout"), ViewVariables(VVAccess.ReadWrite)]
    public float SensorTimeout = 10f;
}
