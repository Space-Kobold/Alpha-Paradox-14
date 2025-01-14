// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedGodmodeSystem))]
public sealed partial class GodmodeComponent : Component
{
    [DataField("wasMovedByPressure")]
    public bool WasMovedByPressure;

    [DataField("oldDamage")]
    public DamageSpecifier? OldDamage = null;
}
