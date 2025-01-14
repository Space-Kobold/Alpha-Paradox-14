// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Spawners.EntitySystems;
using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server.Spawners.Components;

/// <summary>
/// A spawn point that spawns a player into a target container rather than simply spawning them at a position.
/// Occurs before regular spawn points but after arrivals.
/// </summary>
[RegisterComponent]
[Access(typeof(ContainerSpawnPointSystem))]
public sealed partial class ContainerSpawnPointComponent : Component, ISpawnPoint
{
    /// <summary>
    /// The ID of the container that this entity will spawn players into
    /// </summary>
    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public string ContainerId = string.Empty;

    /// <summary>
    /// An optional job specifier
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public ProtoId<JobPrototype>? Job;

    /// <summary>
    /// The type of spawn point
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public SpawnPointType SpawnType { get; set; } = SpawnPointType.Unset;
}
