// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Clock;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedClockSystem))]
[AutoGenerateComponentState]
public sealed partial class ClockComponent : Component
{
    /// <summary>
    /// If not null, this time will be permanently shown.
    /// </summary>
    [DataField, AutoNetworkedField]
    public TimeSpan? StuckTime;

    /// <summary>
    /// The format in which time is displayed.
    /// </summary>
    [DataField, AutoNetworkedField]
    public ClockType ClockType = ClockType.TwelveHour;

    [DataField]
    public string HoursBase = "hours_";

    [DataField]
    public string MinutesBase = "minutes_";
}

[Serializable, NetSerializable]
public enum ClockType : byte
{
    TwelveHour,
    TwentyFourHour
}

[Serializable, NetSerializable]
public enum ClockVisualLayers : byte
{
    HourHand,
    MinuteHand
}
