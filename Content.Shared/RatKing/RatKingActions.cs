// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;

namespace Content.Shared.RatKing;

public sealed partial class RatKingRaiseArmyActionEvent : InstantActionEvent
{

}

public sealed partial class RatKingDomainActionEvent : InstantActionEvent
{

}

public sealed partial class RatKingOrderActionEvent : InstantActionEvent
{
    /// <summary>
    /// The type of order being given
    /// </summary>
    [DataField("type")]
    public RatKingOrderType Type;
}
