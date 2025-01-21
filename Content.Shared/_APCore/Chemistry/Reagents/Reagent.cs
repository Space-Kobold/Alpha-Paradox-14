// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry;
using Robust.Shared.Serialization;
using Robust.Shared.Toolshed.TypeParsers;

namespace Content.Shared._APCore.Chemistry.Reagents;

[Serializable, NetSerializable]
public partial record struct ReagentId(string Id)
    : IEquatable<string>, IComparable<ReagentId>, IAsType<string>
{
    public static implicit operator string(ReagentId protoId)
    {
        return protoId.Id;
    }

    public static implicit operator ReagentId(string id)
    {
        return new ReagentId(id);
    }

    public static implicit operator ReagentId?(string? id)
    {
        return id == null ? default(ReagentId?) : new ReagentId(id);
    }

    public bool Equals(string? other)
    {
        return Id == other;
    }

    public int CompareTo(ReagentId other)
    {
        return string.Compare(Id, other.Id, StringComparison.Ordinal);
    }

    public string AsType() => Id;

    public override string ToString() => Id ?? string.Empty;
}

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
