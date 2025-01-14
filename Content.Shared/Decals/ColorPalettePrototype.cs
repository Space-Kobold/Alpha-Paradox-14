// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Decals;

[Prototype("palette")]
public sealed partial class ColorPalettePrototype : IPrototype
{
    [IdDataField] public string ID { get; } = null!;
    [DataField("name")] public string Name { get; private set; } = null!;
    [DataField("colors")] public Dictionary<string, Color> Colors { get; private set; } = null!;
}
