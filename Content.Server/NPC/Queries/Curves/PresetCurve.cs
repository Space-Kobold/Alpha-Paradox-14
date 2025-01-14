// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.NPC.Queries.Curves;

public sealed partial class PresetCurve : IUtilityCurve
{
    [DataField("preset", required: true, customTypeSerializer:typeof(PrototypeIdSerializer<UtilityCurvePresetPrototype>))] public  string Preset = default!;
}
