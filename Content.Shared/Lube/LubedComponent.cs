// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Lube;

[RegisterComponent]
public sealed partial class LubedComponent : Component
{
    [DataField("slipsLeft"), ViewVariables(VVAccess.ReadWrite)]
    public int SlipsLeft;

    [DataField("slipStrength"), ViewVariables(VVAccess.ReadWrite)]
    public int SlipStrength;
}
