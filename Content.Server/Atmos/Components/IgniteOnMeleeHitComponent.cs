// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Atmos.Components;

/// <summary>
/// Component that can be used to add (or remove) fire stacks when used as a melee weapon.
/// </summary>
[RegisterComponent]
public sealed partial class IgniteOnMeleeHitComponent : Component
{
    [DataField]
    public float FireStacks { get; set; }
}
