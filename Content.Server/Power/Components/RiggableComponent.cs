// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chemistry.Reagent;
using Content.Shared.FixedPoint;

namespace Content.Server.Power.Components;

[RegisterComponent]
public sealed partial class RiggableComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("isRigged")]
    public bool IsRigged;

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("solution")]
    public string Solution = "battery";

    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("reagent")]
    public ReagentQuantity RequiredQuantity = new("Plasma", FixedPoint2.New(5), null);
}
