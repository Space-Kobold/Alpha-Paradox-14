// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos.Piping.Binary.EntitySystems;
using Content.Shared.DeviceLinking;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Atmos.Piping.Binary.Components;

[RegisterComponent, Access(typeof(SignalControlledValveSystem))]
public sealed partial class SignalControlledValveComponent : Component
{
    [DataField("openPort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
    public string OpenPort = "Open";

    [DataField("closePort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
    public string ClosePort = "Close";

    [DataField("togglePort", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
    public string TogglePort = "Toggle";
}
