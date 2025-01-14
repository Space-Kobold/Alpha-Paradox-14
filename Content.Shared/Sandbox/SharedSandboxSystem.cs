// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Sandbox
{
    public abstract class SharedSandboxSystem : EntitySystem
    {
        [Dependency] protected readonly IPrototypeManager PrototypeManager = default!;

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxStatus : EntityEventArgs
        {
            public bool SandboxAllowed { get; set; }
        }

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxRespawn : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxGiveAccess : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxGiveAghost : EntityEventArgs {}

        [Serializable, NetSerializable]
        protected sealed class MsgSandboxSuicide : EntityEventArgs {}
    }
}
