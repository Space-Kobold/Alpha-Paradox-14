// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Pointing.Components;
using System.Numerics;

namespace Content.Client.Pointing.Components;
[RegisterComponent]
public sealed partial class PointingArrowComponent : SharedPointingArrowComponent
{
    /// <summary>
    /// How far the arrow moves up and down during the floating phase.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("offset")]
    public Vector2 Offset = new(0, 0.25f);

    public readonly string AnimationKey = "pointingarrow";
}
