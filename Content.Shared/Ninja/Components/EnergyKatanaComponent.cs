// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Ninja.Components;

/// <summary>
/// Component for a Space Ninja's katana, controls ninja related dash logic.
/// Requires a ninja with a suit for abilities to work.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class EnergyKatanaComponent : Component;
