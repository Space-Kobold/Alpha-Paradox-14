// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Procedural;

[Prototype("dungeonRoomPack")]
public sealed partial class DungeonRoomPackPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = string.Empty;

    /// <summary>
    /// Used to associate the room pack with other room packs with the same dimensions.
    /// </summary>
    [DataField("size", required: true)] public Vector2i Size;

    [DataField("rooms", required: true)] public List<Box2i> Rooms = new();
}
