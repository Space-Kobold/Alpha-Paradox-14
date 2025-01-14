// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.EntityTable.EntitySelectors;

namespace Content.Shared.Procedural.DungeonLayers;


/// <summary>
/// Spawns entities inside of the dungeon randomly.
/// </summary>
public sealed partial class EntityTableDunGen : IDunGenLayer
{
    // Counts separate to config to avoid some duplication.

    [DataField]
    public int MinCount = 1;

    [DataField]
    public int MaxCount = 1;

    [DataField(required: true)]
    public EntityTableSelector Table;
}
