// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Light.Components;

/// <summary>
/// Animates a point light's rotation while enabled.
/// All animation is done in the client system.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState(true)]
[Access(typeof(SharedRotatingLightSystem))]
public sealed partial class RotatingLightComponent : Component
{
    /// <summary>
    /// Speed to rotate at, in degrees per second
    /// </summary>
    [DataField("speed")]
    public float Speed = 90f;

    [ViewVariables, AutoNetworkedField]
    public bool Enabled = true;
}
