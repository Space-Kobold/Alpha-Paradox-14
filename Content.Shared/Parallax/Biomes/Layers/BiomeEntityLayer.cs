// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Maps;
using Robust.Shared.Noise;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Shared.Parallax.Biomes.Layers;

[Serializable, NetSerializable]
public sealed partial class BiomeEntityLayer : IBiomeWorldLayer
{
    /// <inheritdoc/>
    [DataField("allowedTiles", customTypeSerializer:typeof(PrototypeIdListSerializer<ContentTileDefinition>))]
    public List<string> AllowedTiles { get; private set; } = new();

    [DataField("noise")] public FastNoiseLite Noise { get; private set; } = new(0);

    /// <inheritdoc/>
    [DataField("threshold")]
    public float Threshold { get; private set; } = 0.5f;

    /// <inheritdoc/>
    [DataField("invert")] public bool Invert { get; private set; } = false;

    [DataField("entities", required: true, customTypeSerializer: typeof(PrototypeIdListSerializer<EntityPrototype>))]
    public List<string> Entities = new();
}
