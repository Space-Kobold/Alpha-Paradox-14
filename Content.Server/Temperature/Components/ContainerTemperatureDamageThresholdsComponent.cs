// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Temperature.Components;

[RegisterComponent]
public sealed partial class ContainerTemperatureDamageThresholdsComponent: Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float? HeatDamageThreshold;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float? ColdDamageThreshold;
}
