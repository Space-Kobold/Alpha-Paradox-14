// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Noise;

namespace Content.Shared.Parallax.Biomes.Layers;

[ImplicitDataDefinitionForInheritors]
public partial interface IBiomeLayer
{
    /// <summary>
    /// Seed is used an offset from the relevant BiomeComponent's seed.
    /// </summary>
    FastNoiseLite Noise { get; }

    /// <summary>
    /// Threshold for this layer to be present. If set to 0 forces it for every tile.
    /// </summary>
    float Threshold { get; }

    /// <summary>
    /// Is the thresold inverted so we need to be lower than it.
    /// </summary>
    public bool Invert { get; }
}
