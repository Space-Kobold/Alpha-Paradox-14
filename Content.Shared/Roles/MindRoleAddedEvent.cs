// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Roles;

/// <summary>
///     Raised on mind entities when a role is added to them.
///     <see cref="RoleAddedEvent"/> for the one raised on player entities.
/// </summary>
[ByRefEvent]
public readonly record struct MindRoleAddedEvent(bool Silent);
