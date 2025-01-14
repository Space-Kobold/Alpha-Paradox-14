// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Worldgen.Systems;

namespace Content.Server.Worldgen.Components;

/// <summary>
///     This is used for marking a chunk as loaded.
/// </summary>
[RegisterComponent]
[Access(typeof(WorldControllerSystem))]
public sealed partial class LoadedChunkComponent : Component
{
    /// <summary>
    ///     The current list of entities loading this chunk.
    /// </summary>
    [ViewVariables] public List<EntityUid>? Loaders = null;
}

