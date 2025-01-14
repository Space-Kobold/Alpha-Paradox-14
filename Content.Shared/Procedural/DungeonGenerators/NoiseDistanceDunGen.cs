// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Procedural.Distance;

namespace Content.Shared.Procedural.DungeonGenerators;

/// <summary>
/// Like <see cref="Content.Shared.Procedural.DungeonGenerators.NoiseDunGenLayer"/> except with maximum dimensions
/// </summary>
public sealed partial class NoiseDistanceDunGen : IDunGenLayer
{
    [DataField]
    public IDunGenDistance? DistanceConfig;

    [DataField]
    public Vector2i Size;

    [DataField(required: true)]
    public List<NoiseDunGenLayer> Layers = new();
}
