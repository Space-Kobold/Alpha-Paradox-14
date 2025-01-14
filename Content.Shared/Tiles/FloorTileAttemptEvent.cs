// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Tiles;

/// <summary>
/// Raised directed on a grid when attempting a floor tile placement.
/// </summary>
[ByRefEvent]
public record struct FloorTileAttemptEvent(bool Cancelled);
