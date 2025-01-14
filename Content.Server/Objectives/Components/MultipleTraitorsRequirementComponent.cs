// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Requires that there are a certain number of other traitors alive for this objective to be given.
/// </summary>
[RegisterComponent, Access(typeof(MultipleTraitorsRequirementSystem))]
public sealed partial class MultipleTraitorsRequirementComponent : Component
{
    /// <summary>
    /// Number of traitors, excluding yourself, that have to exist.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int Traitors = 2;
}
