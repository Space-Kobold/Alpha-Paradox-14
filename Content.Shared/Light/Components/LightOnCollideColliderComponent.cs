// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Light.Components;

/// <summary>
/// Can activate <see cref="LightOnCollideComponent"/> when collided with.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class LightOnCollideColliderComponent : Component
{
    [DataField]
    public string FixtureId = "lightTrigger";
}
