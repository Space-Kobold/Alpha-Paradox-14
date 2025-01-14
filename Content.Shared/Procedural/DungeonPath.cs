// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural;

/// <summary>
/// Connects 2 dungeon rooms.
/// </summary>
public sealed record DungeonPath(string Tile, string Wall, HashSet<Vector2i> Tiles)
{
    public string Tile = Tile;
    public string Wall = Wall;
}
