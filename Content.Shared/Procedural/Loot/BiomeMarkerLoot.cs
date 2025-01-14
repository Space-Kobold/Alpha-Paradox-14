// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Parallax.Biomes.Markers;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Dictionary;

namespace Content.Shared.Procedural.Loot;

/// <summary>
/// Adds a biome marker layer for dungeon loot.
/// </summary>
public sealed partial class BiomeMarkerLoot : IDungeonLoot
{
    [DataField("proto", required: true)]
    public ProtoId<BiomeMarkerLayerPrototype> Prototype = new();
}
