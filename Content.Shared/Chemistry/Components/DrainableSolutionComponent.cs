// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Chemistry.Components;

/// <summary>
///     Denotes the solution that can be easily removed through any reagent container.
///     Think pouring this or draining from a water tank.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class DrainableSolutionComponent : Component
{
    /// <summary>
    /// Solution name that can be drained.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public string Solution = "default";
}
