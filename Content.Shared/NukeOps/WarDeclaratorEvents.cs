// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.NukeOps;

[Serializable, NetSerializable]
public enum WarDeclaratorUiKey
{
    Key,
}

public enum WarConditionStatus : byte
{
    WarReady,
    YesWar,
    NoWarUnknown,
    NoWarTimeout,
    NoWarSmallCrew,
    NoWarShuttleDeparted
}

[Serializable, NetSerializable]
public sealed class WarDeclaratorBoundUserInterfaceState : BoundUserInterfaceState
{
    public WarConditionStatus? Status;
    public TimeSpan ShuttleDisabledTime;
    public TimeSpan EndTime;

    public WarDeclaratorBoundUserInterfaceState(WarConditionStatus? status, TimeSpan endTime, TimeSpan shuttleDisabledTime)
    {
        Status = status;
        EndTime = endTime;
        ShuttleDisabledTime = shuttleDisabledTime;
    }

}

[Serializable, NetSerializable]
public sealed class WarDeclaratorActivateMessage : BoundUserInterfaceMessage
{
    public string Message { get; }

    public WarDeclaratorActivateMessage(string msg)
    {
        Message = msg;
    }
}
