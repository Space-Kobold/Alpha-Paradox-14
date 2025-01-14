// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;
using Content.Shared.Whitelist;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Requires that the player's mind matches a whitelist.
/// Typical use is checking for (antagonist) roles.
/// </summary>
[RegisterComponent, Access(typeof(RoleRequirementSystem))]
public sealed partial class RoleRequirementComponent : Component
{
    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public EntityWhitelist Roles = new();
}
