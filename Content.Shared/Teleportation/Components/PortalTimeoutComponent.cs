// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Teleportation.Components;

/// <summary>
///     Attached to an entity after portal transit to mark that they should not immediately be portaled back
///     at the end destination.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class PortalTimeoutComponent : Component
{
    /// <summary>
    ///     The portal that was entered. Null if coming from a hand teleporter, etc.
    /// </summary>
    [ViewVariables, DataField, AutoNetworkedField]
    public EntityUid? EnteredPortal;
}
