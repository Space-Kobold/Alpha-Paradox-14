// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Traits.Assorted;

/// <summary>
/// This is used for making something blind forever.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class PermanentBlindnessComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField]
    public int Blindness = 0; // How damaged should their eyes be. Set 0 for maximum damage.
}

