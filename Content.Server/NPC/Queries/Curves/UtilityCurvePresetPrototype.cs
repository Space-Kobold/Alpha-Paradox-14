// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.NPC.Queries.Curves;

[Prototype("utilityCurvePreset")]
public sealed partial class UtilityCurvePresetPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = string.Empty;

    [DataField("curve", required: true)] public IUtilityCurve Curve = default!;
}
