// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Objective condition that requires the player to leave station of escape shuttle with only antags on board or handcuffed humanoids
/// </summary>
[RegisterComponent, Access(typeof(HijackShuttleConditionSystem))]
public sealed partial class HijackShuttleConditionComponent : Component
{
}
