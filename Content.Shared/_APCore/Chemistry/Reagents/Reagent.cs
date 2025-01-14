// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared._APCore.Chemistry.Registry.Systems;

namespace Content.Shared._APCore.Chemistry.Reagents;
public interface IReagent
{
};

public interface IReagent<TSelf> : IReagent, IEquatable<TSelf>
    where TSelf:IReagent<TSelf>
{
    public ReagentDefinition Definition {get;}

    public bool IsValid { get; }

    public bool IsVariant { get; }

    public IVariantData? VariantData { get; }

    public abstract static bool operator ==(TSelf a, TSelf b);
    public abstract static bool operator !=(TSelf a, TSelf b);
}
public interface IVariantData;

public readonly struct Reagent(ReagentDefinition reagentDef, IVariantData? variantData = null) : IReagent<Reagent>
{
    public ReagentDefinition Definition { get; init; } = reagentDef;
    public IVariantData? VariantData { get; init; } = variantData;
    public bool IsVariant => VariantData != null;
    public bool IsValid => true;

    public bool Equals(Reagent other)
    {
        return Definition.Equals(other.Definition)
               && Equals(VariantData, other.VariantData);
    }

    public override bool Equals(object? obj)
    {
        return obj is Reagent other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Definition, VariantData);
    }

    public static bool operator ==(Reagent left, Reagent right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Reagent left, Reagent right)
    {
        return !left.Equals(right);
    }
}
