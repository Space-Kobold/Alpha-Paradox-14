// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Dragon;
using Content.Shared.Roles;

namespace Content.Server.Roles;

/// <summary>
///     Added to mind role entities to tag that they are a space dragon.
/// </summary>
[RegisterComponent, Access(typeof(DragonSystem))]
public sealed partial class DragonRoleComponent : BaseMindRoleComponent
{
}
