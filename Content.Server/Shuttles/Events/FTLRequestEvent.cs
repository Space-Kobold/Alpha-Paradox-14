// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised by a shuttle when it has requested an FTL.
/// </summary>
[ByRefEvent]
public record struct FTLRequestEvent(EntityUid MapUid);
