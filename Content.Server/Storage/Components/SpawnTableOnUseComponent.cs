// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Storage.EntitySystems;
using Content.Shared.EntityTable.EntitySelectors;

namespace Content.Server.Storage.Components;

/// <summary>
/// Spawns items from an entity table when used in hand.
/// </summary>
[RegisterComponent, Access(typeof(SpawnTableOnUseSystem))]
public sealed partial class SpawnTableOnUseComponent : Component
{
    /// <summary>
    /// The entity table to select entities from.
    /// </summary>
    [DataField(required: true)]
    public EntityTableSelector Table = default!;
}
