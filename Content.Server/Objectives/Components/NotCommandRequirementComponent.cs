// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Requires that the player is not a member of command.
/// </summary>
[RegisterComponent, Access(typeof(NotCommandRequirementSystem))]
public sealed partial class NotCommandRequirementComponent : Component
{
}
