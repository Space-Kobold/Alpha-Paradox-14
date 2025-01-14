// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.GameStates;
using Robust.Shared.Utility;

namespace Content.Shared.Physics;

/// <summary>
/// Just draws a generic line between this entity and the target.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class JointVisualsComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("sprite", required: true), AutoNetworkedField]
    public SpriteSpecifier Sprite = default!;

    [ViewVariables(VVAccess.ReadWrite), DataField("target"), AutoNetworkedField]
    public NetEntity? Target;

    /// <summary>
    /// Offset from Body A.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("offsetA"), AutoNetworkedField]
    public Vector2 OffsetA;

    /// <summary>
    /// Offset from Body B.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("offsetB"), AutoNetworkedField]
    public Vector2 OffsetB;
}
