// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Nutrition;

[Prototype("flavor")]
public sealed partial class FlavorPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("flavorType")]
    public FlavorType FlavorType { get; private set; } = FlavorType.Base;

    [DataField("description")]
    public string FlavorDescription { get; private set; } = default!;
}

public enum FlavorType : byte
{
    Base,
    Complex
}
