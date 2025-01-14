// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Research;

[Serializable, NetSerializable]
public enum DiskConsoleUiKey : byte
{
    Key
}

[Serializable, NetSerializable]
public sealed class DiskConsoleBoundUserInterfaceState : BoundUserInterfaceState
{
    public bool CanPrint;
    public int PointCost;
    public int ServerPoints;

    public DiskConsoleBoundUserInterfaceState(int serverPoints, int pointCost, bool canPrint)
    {
        CanPrint = canPrint;
        PointCost = pointCost;
        ServerPoints = serverPoints;
    }
}

[Serializable, NetSerializable]
public sealed class DiskConsolePrintDiskMessage : BoundUserInterfaceMessage
{

}
