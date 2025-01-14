// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Preferences;
using Robust.Shared.Prototypes;

namespace Content.Shared.Humanoid.Prototypes;

[Prototype("humanoidProfile")]
public sealed partial class HumanoidProfilePrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("customBaseLayers")]
    public Dictionary<HumanoidVisualLayers, CustomBaseLayerInfo> CustomBaseLayers = new();

    [DataField("profile")]
    public HumanoidCharacterProfile Profile { get; private set; } = new();
}
