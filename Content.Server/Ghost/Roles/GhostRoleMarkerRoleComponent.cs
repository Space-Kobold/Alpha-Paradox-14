// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;

namespace Content.Server.Ghost.Roles;

/// <summary>
/// This is used for round end display of ghost roles.
/// It may also be used to ensure some ghost roles count as antagonists in future.
/// </summary>
[RegisterComponent]
public sealed partial class GhostRoleMarkerRoleComponent : BaseMindRoleComponent
{
    [DataField("name")] public string? Name;
}
