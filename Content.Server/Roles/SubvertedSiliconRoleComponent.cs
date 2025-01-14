// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;

namespace Content.Server.Roles;

/// <summary>
///     Added to mind role entities to tag that they are a hacked borg.
/// </summary>
[RegisterComponent]
public sealed partial class SubvertedSiliconRoleComponent : BaseMindRoleComponent
{
}
