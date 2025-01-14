// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared.FixedPoint;

namespace Content.Shared._APCore.Chemistry.Reagents;

public readonly struct ReagentQuantity(Reagent reagent, FixedPoint2 quantity)
    : IReagent<ReagentQuantity>
{
    public readonly Reagent Reagent = reagent;

    public ReagentDefinition Definition => Reagent.Definition;
    public bool IsValid => Reagent.IsValid;
    public bool IsVariant => Reagent.IsVariant;
    public IVariantData? VariantData => Reagent.VariantData;
    public FixedPoint2 Quantity { get; init; } = quantity;
    public ReagentQuantity(ReagentQuantity old, FixedPoint2 newQuantity) : this(old.Reagent, newQuantity){}

    public void Deconstruct(out Reagent reagent, out FixedPoint2 quantity)
    {
        reagent = Reagent;
        quantity = Quantity;
    }

    public static ReagentQuantity operator +(ReagentQuantity a, FixedPoint2 b)
    {
        return new ReagentQuantity(a, a.Quantity + b);
    }

    public static ReagentQuantity operator -(ReagentQuantity a, FixedPoint2 b)
    {
        return new ReagentQuantity(a, a.Quantity - b);
    }

    public static ReagentQuantity operator /(ReagentQuantity a, FixedPoint2 b)
    {
        return new ReagentQuantity(a, a.Quantity / b);
    }

    public static ReagentQuantity operator *(ReagentQuantity a, FixedPoint2 b)
    {
        return new ReagentQuantity(a, a.Quantity * b);
    }

    public static bool operator ==(ReagentQuantity a, ReagentQuantity b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(ReagentQuantity a, ReagentQuantity b)
    {
        return !a.Equals(b);
    }

    public static bool operator ==(ReagentQuantity a, FixedPoint2 b)
    {
        return a.Quantity == b;
    }

    public static bool operator !=(ReagentQuantity a, FixedPoint2 b)
    {
        return a.Quantity == b;
    }

    public override bool Equals(object? obj)
    {
        return obj is ReagentQuantity other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Definition, VariantData, Quantity);
    }

    public bool Equals(ReagentQuantity other)
    {
        return Definition.Equals(other.Definition)
               && Equals(VariantData, other.VariantData)
               && Quantity.Equals(other.Quantity);
    }
}
