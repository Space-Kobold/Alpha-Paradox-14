// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Inventory.VirtualItem;

/// <inheritdoc cref="SharedVirtualItemSystem"/>
[RegisterComponent]
[NetworkedComponent]
[AutoGenerateComponentState(true)]
public sealed partial class VirtualItemComponent : Component
{
    /// <summary>
    /// The entity blocking this slot.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid BlockingEntity;
}
