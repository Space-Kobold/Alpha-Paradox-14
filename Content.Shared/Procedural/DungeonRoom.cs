// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;

namespace Content.Shared.Procedural;

// TODO: Cache center and bounds and shit and don't make the caller deal with it.
public sealed record DungeonRoom(HashSet<Vector2i> Tiles, Vector2 Center, Box2i Bounds, HashSet<Vector2i> Exterior)
{
    public readonly List<Vector2i> Entrances = new();

    /// <summary>
    /// Nodes adjacent to tiles, including the corners.
    /// </summary>
    public readonly HashSet<Vector2i> Exterior = Exterior;
}
