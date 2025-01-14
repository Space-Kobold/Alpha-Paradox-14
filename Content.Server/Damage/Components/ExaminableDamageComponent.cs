// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Damage.Components;

/// <summary>
///     This component shows entity damage severity when it is examined by player.
/// </summary>
[RegisterComponent]
public sealed partial class ExaminableDamageComponent : Component
{
    [DataField("messages", required: true, customTypeSerializer:typeof(PrototypeIdSerializer<ExaminableDamagePrototype>))]
    public string? MessagesProtoId;

    public ExaminableDamagePrototype? MessagesProto;
}
