// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.DeviceLinking;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Explosion.Components
{
    /// <summary>
    /// Sends a trigger when signal is received.
    /// </summary>
    [RegisterComponent]
    public sealed partial class TimerStartOnSignalComponent : Component
    {
        [DataField("port", customTypeSerializer: typeof(PrototypeIdSerializer<SinkPortPrototype>))]
        public string Port = "Timer";
    }
}
