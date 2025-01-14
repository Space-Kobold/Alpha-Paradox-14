// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Shared.Camera;

[RegisterComponent]
[NetworkedComponent]
public sealed partial class CameraRecoilComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    public Vector2 CurrentKick { get; set; }

    [ViewVariables(VVAccess.ReadWrite)]
    public Vector2 LastKick { get; set; }
    
    [ViewVariables(VVAccess.ReadWrite)]
    public float LastKickTime { get; set; }

    /// <summary>
    ///     Basically I needed a way to chain this effect for the attack lunge animation. Sorry!
    /// </summary>
    ///
    [ViewVariables(VVAccess.ReadWrite)]
    public Vector2 BaseOffset { get; set; }
}
