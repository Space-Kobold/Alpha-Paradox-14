// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Clothing;

/// <summary>
/// Modifies speed when worn and activated.
/// Supports <c>ItemToggleComponent</c>.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(ClothingSpeedModifierSystem))]
public sealed partial class ClothingSpeedModifierComponent : Component
{
    [DataField]
    public float WalkModifier = 1.0f;

    [DataField]
    public float SprintModifier = 1.0f;
}

[Serializable, NetSerializable]
public sealed class ClothingSpeedModifierComponentState : ComponentState
{
    public float WalkModifier;
    public float SprintModifier;

    public ClothingSpeedModifierComponentState(float walkModifier, float sprintModifier)
    {
        WalkModifier = walkModifier;
        SprintModifier = sprintModifier;
    }
}
