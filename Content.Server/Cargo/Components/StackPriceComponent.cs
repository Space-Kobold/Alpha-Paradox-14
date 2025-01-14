// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Cargo.Components;

/// <summary>
/// This is used for pricing stacks of items.
/// </summary>
[RegisterComponent]
public sealed partial class StackPriceComponent : Component
{
    /// <summary>
    /// The price of the object this component is on, per unit.
    /// </summary>
    [DataField("price", required: true)]
    public double Price;
}
