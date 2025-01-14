// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Explosion.Components;

/// <summary>
///     Disallows starting the timer by hand, must be stuck or triggered by a system using <c>StartTimer</c>.
/// </summary>
[RegisterComponent]
public sealed partial class AutomatedTimerComponent : Component
{
}
