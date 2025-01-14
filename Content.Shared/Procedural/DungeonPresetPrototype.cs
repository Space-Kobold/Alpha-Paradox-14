// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Procedural;

[Prototype("dungeonPreset")]
public sealed partial class DungeonPresetPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = default!;

    /// <summary>
    /// The room pack bounds we need to fill.
    /// </summary>
    [DataField("roomPacks", required: true)]
    public List<Box2i> RoomPacks = new();
}
