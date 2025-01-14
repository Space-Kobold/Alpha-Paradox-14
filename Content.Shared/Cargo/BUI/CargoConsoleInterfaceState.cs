// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Cargo.BUI;

[NetSerializable, Serializable]
public sealed class CargoConsoleInterfaceState : BoundUserInterfaceState
{
    public string Name;
    public int Count;
    public int Capacity;
    public int Balance;
    public List<CargoOrderData> Orders;

    public CargoConsoleInterfaceState(string name, int count, int capacity, int balance, List<CargoOrderData> orders)
    {
        Name = name;
        Count = count;
        Capacity = capacity;
        Balance = balance;
        Orders = orders;
    }
}