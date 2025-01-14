// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.CartridgeLoader;

[Serializable, NetSerializable]
public sealed class CartridgeLoaderUiMessage : BoundUserInterfaceMessage
{
    public readonly NetEntity CartridgeUid;
    public readonly CartridgeUiMessageAction Action;

    public CartridgeLoaderUiMessage(NetEntity cartridgeUid, CartridgeUiMessageAction action)
    {
        CartridgeUid = cartridgeUid;
        Action = action;
    }
}

[Serializable, NetSerializable]
public enum CartridgeUiMessageAction
{
    Activate,
    Deactivate,
    Install,
    Uninstall,
    UIReady
}
