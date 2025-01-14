// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chat.Prototypes;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;

namespace Content.Shared.Chat;

[Serializable, NetSerializable]
public sealed class PlayEmoteMessage(ProtoId<EmotePrototype> protoId) : EntityEventArgs
{
    public readonly ProtoId<EmotePrototype> ProtoId = protoId;
}
