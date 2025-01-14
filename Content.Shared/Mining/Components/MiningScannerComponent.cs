// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Mining.Components;

/// <summary>
/// This is a component that, when held in the inventory or pocket of a player, gives the the MiningOverlay.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(MiningScannerSystem))]
public sealed partial class MiningScannerComponent : Component
{
    [DataField]
    public float Range = 5;
}
