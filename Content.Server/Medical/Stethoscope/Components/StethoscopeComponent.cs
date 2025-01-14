// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Medical.Stethoscope.Components
{
    /// <summary>
    /// Adds an innate verb when equipped to use a stethoscope.
    /// </summary>
    [RegisterComponent]
    public sealed partial class StethoscopeComponent : Component
    {
        public bool IsActive = false;

        [DataField("delay")]
        public float Delay = 2.5f;

        [DataField("action", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string Action = "ActionStethoscope";

        [DataField("actionEntity")] public EntityUid? ActionEntity;
    }
}
