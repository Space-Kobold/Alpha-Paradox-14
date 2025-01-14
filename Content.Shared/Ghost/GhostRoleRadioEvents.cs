// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Ghost.Roles;

[Serializable, NetSerializable]
public sealed class GhostRoleRadioMessage : BoundUserInterfaceMessage
{
    public ProtoId<GhostRolePrototype> ProtoId;

    public GhostRoleRadioMessage(ProtoId<GhostRolePrototype> protoId)
    {
        ProtoId = protoId;
    }
}

[Serializable, NetSerializable]
public enum GhostRoleRadioUiKey : byte
{
    Key
}
