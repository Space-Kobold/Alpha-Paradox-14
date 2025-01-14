// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

//using Robust.Shared.GameObjects;
using Robust.Shared.GameStates;
using Robust.Shared.Utility;

namespace Content.Shared.Silicons.Borgs.Components;

/// <summary>
/// This is used to override the action icon for cyborg actions.
/// Without this component the no-action state will be used.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class BorgModuleIconComponent : Component
{
    /// <summary>
    /// The action icon for this module
    /// </summary>
    [DataField]
    public SpriteSpecifier.Rsi Icon = default!;

}