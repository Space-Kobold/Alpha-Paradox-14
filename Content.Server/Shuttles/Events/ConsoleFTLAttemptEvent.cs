// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised when a shuttle console is trying to FTL via UI input.
/// </summary>
/// <param name="Cancelled"></param>
/// <param name="Reason"></param>
[ByRefEvent]
public record struct ConsoleFTLAttemptEvent(EntityUid Uid, bool Cancelled, string Reason);
