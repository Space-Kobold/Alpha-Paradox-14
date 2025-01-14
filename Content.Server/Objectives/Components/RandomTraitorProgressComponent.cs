// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Sets the target for <see cref="HelpProgressConditionComponent"/> to a random traitor.
/// </summary>
[RegisterComponent, Access(typeof(HelpProgressConditionSystem))]
public sealed partial class RandomTraitorProgressComponent : Component
{
}
