// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Traits.Assorted;

/// <summary>
/// Set player speed to zero and standing state to down, simulating leg paralysis.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(LegsParalyzedSystem))]
public sealed partial class LegsParalyzedComponent : Component
{
}
