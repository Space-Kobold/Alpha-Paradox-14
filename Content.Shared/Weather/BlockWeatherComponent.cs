// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Weather;

/// <summary>
/// This entity will block the weather if it's anchored to the floor.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class BlockWeatherComponent : Component
{

}
