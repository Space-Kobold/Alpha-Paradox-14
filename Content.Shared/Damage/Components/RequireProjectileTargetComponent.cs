// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

/// <summary>
/// Prevent the object from getting hit by projetiles unless you target the object.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(RequireProjectileTargetSystem))]
public sealed partial class RequireProjectileTargetComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool Active = true;
}
