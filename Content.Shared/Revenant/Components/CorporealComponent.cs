// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Revenant.Components;

/// <summary>
/// Makes the target solid, visible, and applies a slowdown.
/// Meant to be used in conjunction with statusEffectSystem
/// </summary>
[RegisterComponent]
public sealed partial class CorporealComponent : Component
{
    /// <summary>
    /// The debuff applied when the component is present.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float MovementSpeedDebuff = 0.66f;
}
