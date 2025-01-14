// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.CartridgeLoader.Cartridges;

[Serializable, NetSerializable]
public sealed class NotekeeperUiMessageEvent : CartridgeMessageEvent
{
    public readonly NotekeeperUiAction Action;
    public readonly string Note;

    public NotekeeperUiMessageEvent(NotekeeperUiAction action, string note)
    {
        Action = action;
        Note = note;
    }
}

[Serializable, NetSerializable]
public enum NotekeeperUiAction
{
    Add,
    Remove
}
