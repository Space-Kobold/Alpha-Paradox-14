// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.NPC;

namespace Content.Server.NPC.Pathfinding;

public sealed class GridPathfindingChunk
{
    // TODO: Make this a 1d array
    [ViewVariables]
    public readonly PathfindingBreadcrumb[,] Points = new PathfindingBreadcrumb[
        (SharedPathfindingSystem.ChunkSize) * SharedPathfindingSystem.SubStep,
        (SharedPathfindingSystem.ChunkSize) * SharedPathfindingSystem.SubStep];

    [ViewVariables]
    public Vector2i Origin;

    [ViewVariables]
    public readonly List<PathPoly>[] Polygons = new List<PathPoly>[SharedPathfindingSystem.ChunkSize * SharedPathfindingSystem.ChunkSize];

    /// <summary>
    /// Store the recalculated polygons to know what needs changing.
    /// </summary>
    internal readonly List<PathPoly>[] BufferPolygons = new List<PathPoly>[SharedPathfindingSystem.ChunkSize * SharedPathfindingSystem.ChunkSize];

    /// <summary>
    /// The relevant polygon for this chunk's portals
    /// </summary>
    [ViewVariables]
    public readonly Dictionary<PathPortal, PathPoly> PortalPolys = new();

    /// <summary>
    /// This chunk's portals.
    /// </summary>
    [ViewVariables]
    public readonly List<PathPortal> Portals = new();

    public GridPathfindingChunk()
    {
        for (var x = 0; x < Polygons.Length; x++)
        {
            Polygons[x] = new List<PathPoly>();
            BufferPolygons[x] = new List<PathPoly>();
        }
    }
}
