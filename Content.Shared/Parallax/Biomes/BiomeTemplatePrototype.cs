// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Parallax.Biomes.Layers;
using Robust.Shared.Prototypes;

namespace Content.Shared.Parallax.Biomes;

/// <summary>
/// A preset group of biome layers to be used for a <see cref="BiomeComponent"/>
/// </summary>
[Prototype("biomeTemplate")]
public sealed partial class BiomeTemplatePrototype : IPrototype
{
    [IdDataField] public string ID { get; } = default!;

    [DataField("layers")]
    public List<IBiomeLayer> Layers = new();
}
