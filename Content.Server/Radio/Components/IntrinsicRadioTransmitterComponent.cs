// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Chat.Systems;
using Content.Shared.Chat;
using Content.Shared.Radio;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Set;

namespace Content.Server.Radio.Components;

/// <summary>
///     This component allows an entity to directly translate spoken text into radio messages (effectively an intrinsic
///     radio headset).
/// </summary>
[RegisterComponent]
public sealed partial class IntrinsicRadioTransmitterComponent : Component
{
    [DataField("channels", customTypeSerializer: typeof(PrototypeIdHashSetSerializer<RadioChannelPrototype>))]
    public HashSet<string> Channels = new() { SharedChatSystem.CommonChannel };
}
