// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Power.Visualizers;

[RegisterComponent]
public sealed partial class CableVisualizerComponent : Component
{
    [DataField("statePrefix")]
    public string? StatePrefix;
}
