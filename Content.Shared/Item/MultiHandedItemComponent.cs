// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Item;

/// <summary>
/// This is used for items that need
/// multiple hands to be able to be picked up
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class MultiHandedItemComponent : Component
{
    [DataField("handsNeeded"), ViewVariables(VVAccess.ReadWrite)]
    public int HandsNeeded = 2;
}
