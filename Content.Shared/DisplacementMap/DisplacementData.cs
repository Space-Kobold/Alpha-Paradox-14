// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.DisplacementMap;

[DataDefinition]
public sealed partial class DisplacementData
{
    /// <summary>
    /// allows you to attach different maps for layers of different sizes.
    /// </summary>
    [DataField(required: true)]
    public Dictionary<int, PrototypeLayerData> SizeMaps = new();

    [DataField]
    public string? ShaderOverride = "DisplacedStencilDraw";
}
