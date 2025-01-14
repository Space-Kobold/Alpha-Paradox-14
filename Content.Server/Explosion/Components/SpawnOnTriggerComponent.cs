// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.EntitySystems;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Explosion.Components;

[RegisterComponent, Access(typeof(TriggerSystem))]
public sealed partial class SpawnOnTriggerComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("proto", required: true, customTypeSerializer:typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string Proto = string.Empty;
}
