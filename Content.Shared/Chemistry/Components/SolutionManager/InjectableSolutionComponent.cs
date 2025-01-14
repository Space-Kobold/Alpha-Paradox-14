// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Chemistry.Components.SolutionManager;

/// <summary>
///     Denotes a solution which can be added with syringes.
/// </summary>
[RegisterComponent]
public sealed partial class InjectableSolutionComponent : Component
{

    /// <summary>
    /// Solution name which can be added with syringes.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public string Solution = "default";
}
