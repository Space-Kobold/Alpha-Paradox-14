// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared.Ghost;

[Serializable, NetSerializable]
public sealed class ReturnToBodyMessage : EuiMessageBase
{
    public readonly bool Accepted;

    public ReturnToBodyMessage(bool accepted)
    {
        Accepted = accepted;
    }
}
