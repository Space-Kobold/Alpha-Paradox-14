// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Clock;

/// <summary>
/// This is used for globally managing the time on-station
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, AutoGenerateComponentPause, Access(typeof(SharedClockSystem))]
public sealed partial class GlobalTimeManagerComponent : Component
{
    /// <summary>
    /// A fixed random offset, used to fuzz the time between shifts.
    /// </summary>
    [DataField, AutoPausedField, AutoNetworkedField]
    public TimeSpan TimeOffset;
}
