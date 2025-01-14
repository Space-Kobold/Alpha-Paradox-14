// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.CombatMode.Pacification;

/// <summary>
/// This is used for marking entities which could cause serious harm if attacked and should not be able to be harmed by
/// pacifists.
/// TODO ideally destructible is shared + converted to components so we can just check for a harmful damage trigger instead of this.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class PacifismDangerousAttackComponent : Component
{
}
