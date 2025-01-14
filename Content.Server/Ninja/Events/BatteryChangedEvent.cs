// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Ninja.Events;

/// <summary>
/// Raised on the ninja and suit when the suit has its powercell changed.
/// </summary>
[ByRefEvent]
public record struct NinjaBatteryChangedEvent(EntityUid Battery, EntityUid BatteryHolder);
