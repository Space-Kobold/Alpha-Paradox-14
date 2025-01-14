// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.SprayPainter.Prototypes;

[Prototype("AirlockGroup")]
public sealed partial class AirlockGroupPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("stylePaths")]
    public Dictionary<string, string> StylePaths = default!;

    // The priority determines, which sprite is used when showing
    // the icon for a style in the SprayPainter UI. The highest priority
    // gets shown.
    [DataField("iconPriority")]
    public int IconPriority = 0;
}
