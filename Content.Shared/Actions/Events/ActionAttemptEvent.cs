// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Actions.Events;

/// <summary>
/// Raised before an action is used and can be cancelled to prevent it.
/// Allowed to have side effects like modifying the action component.
/// </summary>
[ByRefEvent]
public record struct ActionAttemptEvent(EntityUid User, bool Cancelled = false);
