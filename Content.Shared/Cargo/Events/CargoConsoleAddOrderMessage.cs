// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Cargo.Events;

/// <summary>
///     Add order to database.
/// </summary>
[Serializable, NetSerializable]
public sealed class CargoConsoleAddOrderMessage : BoundUserInterfaceMessage
{
    public string Requester;
    public string Reason;
    public string CargoProductId;
    public int Amount;

    public CargoConsoleAddOrderMessage(string requester, string reason, string cargoProductId, int amount)
    {
        Requester = requester;
        Reason = reason;
        CargoProductId = cargoProductId;
        Amount = amount;
    }
}
