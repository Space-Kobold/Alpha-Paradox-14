// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Bed.Sleep;

/// <summary>
///     Raised by an entity about to fall asleep.
///     Set Cancelled to true on event handling to interrupt
/// </summary>
[ByRefEvent]
public record struct TryingToSleepEvent(EntityUid uid, bool Cancelled = false);
