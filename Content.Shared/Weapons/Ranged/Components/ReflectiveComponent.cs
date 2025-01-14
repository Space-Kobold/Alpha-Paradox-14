// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Weapons.Reflect;
using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Ranged.Components;

/// <summary>
/// Can this entity be reflected.
/// Only applies if it is shot like a projectile and not if it is thrown.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ReflectiveComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("reflective")]
    public ReflectType Reflective = ReflectType.NonEnergy;
}
