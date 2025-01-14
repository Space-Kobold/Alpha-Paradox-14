// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Collections;
using Robust.Shared.Map;
using Robust.Shared.Map.Components;

namespace Content.Server.Spreader;

/// <summary>
/// Raised when trying to spread to neighboring tiles.
/// If the spread is no longer able to happen you MUST cancel this event!
/// </summary>
[ByRefEvent]
public record struct SpreadNeighborsEvent
{
    public ValueList<(MapGridComponent Grid, TileRef Tile)> NeighborFreeTiles;
    public ValueList<EntityUid> Neighbors;

    /// <summary>
    /// How many updates allowed are remaining.
    /// Subscribers can handle as they wish.
    /// </summary>
    public int Updates;
}
