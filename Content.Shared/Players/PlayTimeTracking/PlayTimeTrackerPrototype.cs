// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Players.PlayTimeTracking;

/// <summary>
/// Given to a role to specify its ID for role-timer tracking purposes. That's it.
/// </summary>
[Prototype("playTimeTracker")]
public sealed partial class PlayTimeTrackerPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = default!;
}
