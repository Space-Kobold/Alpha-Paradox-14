// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Morgue.Components;

/// <summary>
/// used to track actively cooking crematoriums
/// </summary>
[RegisterComponent]
public sealed partial class ActiveCrematoriumComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public float Accumulator = 0;
}
