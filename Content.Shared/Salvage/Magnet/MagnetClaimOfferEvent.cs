// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Salvage.Magnet;

/// <summary>
/// Claim an offer from the magnet UI.
/// </summary>
[Serializable, NetSerializable]
public sealed class MagnetClaimOfferEvent : BoundUserInterfaceMessage
{
    public int Index;
}
