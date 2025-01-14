// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Inventory.Events;

[NetSerializable, Serializable]
public sealed class UseSlotNetworkMessage : EntityEventArgs
{
    // The slot-owner is implicitly the client that is sending this message.
    // Otherwise clients could start forcefully undressing other clients.
    public readonly string Slot;

    public UseSlotNetworkMessage(string slot)
    {
        Slot = slot;
    }
}
