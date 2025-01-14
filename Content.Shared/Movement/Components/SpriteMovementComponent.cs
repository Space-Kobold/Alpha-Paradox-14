// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

/// <summary>
/// Updates a sprite layer based on whether an entity is moving via input or not.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
public sealed partial class SpriteMovementComponent : Component
{
    /// <summary>
    /// Layer and sprite state to use when moving.
    /// </summary>
    [DataField]
    public Dictionary<string, PrototypeLayerData> MovementLayers = new();

    /// <summary>
    /// Layer and sprite state to use when not moving.
    /// </summary>
    [DataField]
    public Dictionary<string, PrototypeLayerData> NoMovementLayers = new();

    [DataField, AutoNetworkedField]
    public bool IsMoving;
}
