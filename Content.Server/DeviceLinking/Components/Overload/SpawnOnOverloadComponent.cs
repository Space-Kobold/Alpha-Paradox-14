// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceLinking.Systems;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.DeviceLinking.Components.Overload;

/// <summary>
/// Spawns an entity when a device link overloads.
/// An overload happens when a device link sink is invoked to many times per tick
/// and it raises a <see cref="Content.Server.DeviceLinking.Events.DeviceLinkOverloadedEvent"/>
/// </summary>
[RegisterComponent]
[Access(typeof(DeviceLinkOverloadSystem))]
public sealed partial class SpawnOnOverloadComponent : Component
{
    /// <summary>
    /// The entity prototype to spawn when the device overloads
    /// </summary>
    [DataField("spawnedPrototype", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string Prototype = "PuddleSparkle";
}
