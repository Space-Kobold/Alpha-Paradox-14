// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Worldgen.Systems;

namespace Content.Server.Worldgen.Components;

/// <summary>
///     This is used for marking an entity as being a world chunk.
/// </summary>
[RegisterComponent]
[Access(typeof(WorldControllerSystem))]
public sealed partial class WorldChunkComponent : Component
{
    /// <summary>
    ///     The coordinates of the chunk, in chunk space.
    /// </summary>
    [DataField("coordinates")] public Vector2i Coordinates;

    /// <summary>
    ///     The map this chunk belongs to.
    /// </summary>
    [DataField("map")] public EntityUid Map;
}

