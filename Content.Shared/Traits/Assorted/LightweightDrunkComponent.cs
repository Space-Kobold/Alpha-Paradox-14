// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Content.Shared.Drunk;

namespace Content.Shared.Traits.Assorted;

/// <summary>
/// Used for the lightweight trait. DrunkSystem will check for this component and modify the boozePower accordingly if it finds it.
/// </summary>
[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedDrunkSystem))]
public sealed partial class LightweightDrunkComponent : Component
{
    [DataField("boozeStrengthMultiplier"), ViewVariables(VVAccess.ReadWrite)]
    public float BoozeStrengthMultiplier = 4f;
}
