// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Just requires that the player is not dead, ignores evac and what not.
/// </summary>
[RegisterComponent, Access(typeof(SurviveConditionSystem))]
public sealed partial class SurviveConditionComponent : Component
{
}
