// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Containers;

/// <summary>
/// This is used for a container that is exited when the entity inside of it moves.
/// </summary>
[RegisterComponent, NetworkedComponent]
[Access(typeof(ExitContainerOnMoveSystem))]
public sealed partial class ExitContainerOnMoveComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public string ContainerId;
}
