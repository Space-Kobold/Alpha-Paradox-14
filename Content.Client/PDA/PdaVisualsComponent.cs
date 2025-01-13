// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.PDA;

/// <summary>
/// Used for visualizing PDA visuals.
/// </summary>
[RegisterComponent]
public sealed partial class PdaVisualsComponent : Component
{
    public string? BorderColor;

    public string? AccentHColor;

    public string? AccentVColor;
}
