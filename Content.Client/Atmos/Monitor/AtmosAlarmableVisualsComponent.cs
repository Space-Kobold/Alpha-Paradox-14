// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Atmos.Monitor;

namespace Content.Client.Atmos.Monitor;

[RegisterComponent]
public sealed partial class AtmosAlarmableVisualsComponent : Component
{
    [DataField("layerMap")]
    public string LayerMap { get; private set; } = string.Empty;

    [DataField("alarmStates")]
    public Dictionary<AtmosAlarmType, string> AlarmStates = new();

    [DataField("hideOnDepowered")]
    public List<string>? HideOnDepowered;

    // eh...
    [DataField("setOnDepowered")]
    public Dictionary<string, string>? SetOnDepowered;
}
