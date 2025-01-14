// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

/// <summary>
/// Automatically rotates eye upon grid traversals.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause]
public sealed partial class AutoOrientComponent : Component
{
    [DataField, AutoNetworkedField, AutoPausedField]
    public TimeSpan? NextChange;
}
