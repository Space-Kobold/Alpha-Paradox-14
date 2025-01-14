// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Station.Components;

/// <summary>
/// Indicates that a grid is a member of the given station.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class StationMemberComponent : Component
{
    /// <summary>
    /// Station that this grid is a part of.
    /// </summary>
    [DataField]
    public EntityUid Station = EntityUid.Invalid;
}
