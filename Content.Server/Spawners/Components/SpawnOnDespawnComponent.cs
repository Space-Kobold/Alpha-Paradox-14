// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Spawners.EntitySystems;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Spawners.Components;

/// <summary>
/// When a <c>TimedDespawnComponent"</c> despawns, another one will be spawned in its place.
/// </summary>
[RegisterComponent, Access(typeof(SpawnOnDespawnSystem))]
public sealed partial class SpawnOnDespawnComponent : Component
{
    /// <summary>
    /// Entity prototype to spawn.
    /// </summary>
    [DataField(required: true)]
    public EntProtoId Prototype = string.Empty;
}
