// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Radio;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Set;

namespace Content.Server.Radio.Components;

/// <summary>
///     This component is required to receive radio message events.
/// </summary>
[RegisterComponent]
public sealed partial class ActiveRadioComponent : Component
{
    /// <summary>
    ///     The channels that this radio is listening on.
    /// </summary>
    [DataField("channels", customTypeSerializer: typeof(PrototypeIdHashSetSerializer<RadioChannelPrototype>))]
    public HashSet<string> Channels = new();

    /// <summary>
    /// A toggle for globally receiving all radio channels.
    /// Overrides <see cref="Channels"/>
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public bool ReceiveAllChannels;

    /// <summary>
    ///     If this radio can hear all messages on all maps
    /// </summary>
    [DataField("globalReceive")]
    public bool GlobalReceive = false;
}
