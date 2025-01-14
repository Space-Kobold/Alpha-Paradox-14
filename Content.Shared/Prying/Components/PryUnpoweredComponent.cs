// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Prying.Components;

///<summary>
/// Applied to entities that can be pried open without tools while unpowered
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class PryUnpoweredComponent : Component
{
    [DataField]
    public float PryModifier = 0.1f;
}
