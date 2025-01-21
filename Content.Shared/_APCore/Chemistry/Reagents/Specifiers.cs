// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception
using Content.Shared.FixedPoint;

namespace Content.Shared._APCore.Chemistry.Reagents;

[DataDefinition]
public partial struct ReagentSpecifier
{
    [DataField(required:true)]
    public ReagentId Reagent;

    [DataField]
    public IVariantData? VariantData = null;
}

[DataDefinition]
public sealed partial class ReagentQuantitySpecifier
{

    [IncludeDataField]
    public ReagentSpecifier Reagent;

    [DataField(required:true)]
    public FixedPoint2 Quantity;
}
