// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Holiday;

/// <summary>
/// This is used for a component that swaps an entity's RSI based on HolidayVisuals
/// </summary>
[RegisterComponent]
public sealed partial class HolidayRsiSwapComponent : Component
{
    /// <summary>
    /// A dictionary of arbitrary visual keys to an rsi to swap the sprite to.
    /// </summary>
    [DataField]
    public Dictionary<string, string> Sprite = new();
}
