// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Requires that the dragon open and fully charge a certain number of rifts.
/// Depends on <see cref="NumberObjective"/> to function.
/// </summary>
[RegisterComponent, Access(typeof(CarpRiftsConditionSystem))]
public sealed partial class CarpRiftsConditionComponent : Component
{
    /// <summary>
    /// The number of rifts currently charged.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int RiftsCharged;
}
