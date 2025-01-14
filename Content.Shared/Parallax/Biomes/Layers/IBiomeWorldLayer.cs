// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Parallax.Biomes.Layers;

/// <summary>
/// Handles actual objects such as decals and entities.
/// </summary>
public partial interface IBiomeWorldLayer : IBiomeLayer
{
    /// <summary>
    /// What tiles we're allowed to spawn on, real or biome.
    /// </summary>
    List<string> AllowedTiles { get; }
}
