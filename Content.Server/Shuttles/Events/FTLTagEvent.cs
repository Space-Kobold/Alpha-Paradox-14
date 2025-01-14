// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised when trying to get a priority tag for docking.
/// </summary>
[ByRefEvent]
public record struct FTLTagEvent(bool Handled, string? Tag);
