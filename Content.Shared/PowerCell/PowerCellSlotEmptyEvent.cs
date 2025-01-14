// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.PowerCell;

/// <summary>
/// Raised directed on an entity when its active power cell has no more charge to supply.
/// </summary>
[ByRefEvent]
public readonly record struct PowerCellSlotEmptyEvent;
