// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chat;
using Content.Shared.Inventory;

namespace Content.Shared.Radio;

public sealed class GetDefaultRadioChannelEvent : EntityEventArgs, IInventoryRelayEvent
{
    /// <summary>
    ///     Id of the default <see cref="RadioChannelPrototype"/> that will get addressed when using the
    ///     department/default channel prefix. See <see cref="SharedChatSystem.DefaultChannelKey"/>.
    /// </summary>
    public string? Channel;

    public SlotFlags TargetSlots => ~SlotFlags.POCKET;
}
