// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Burial.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class ShovelComponent : Component
{
    /// <summary>
    /// The speed modifier for how fast this shovel will dig.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float SpeedModifier = 1f;
}
