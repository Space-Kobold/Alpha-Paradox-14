// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Electrocution;

/// <summary>
/// Updates every frame for short duration to check if electrifed entity is powered when activated, e.g to play animation
/// </summary>
[RegisterComponent]
public sealed partial class ActivatedElectrifiedComponent : Component
{
    /// <summary>
    /// How long electrified entity will remain active
    /// </summary>
    [ViewVariables]
    public float TimeLeft = 1f;
}
