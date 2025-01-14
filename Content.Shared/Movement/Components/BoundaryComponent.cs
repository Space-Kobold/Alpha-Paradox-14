// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

/// <summary>
/// Represents a boundary that can bump someone back when touched.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class BoundaryComponent : Component
{
    [DataField, AutoNetworkedField]
    public float Offset = 2f;
}
