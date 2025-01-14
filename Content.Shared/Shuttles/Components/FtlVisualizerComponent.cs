// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Utility;

namespace Content.Shared.Shuttles.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FtlVisualizerComponent : Component
{
    /// <summary>
    /// Clientside time tracker for the animation.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float Elapsed;

    [DataField(required: true)]
    public SpriteSpecifier.Rsi Sprite;

    /// <summary>
    /// Target grid to pull FTL visualization from.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid Grid;
}
