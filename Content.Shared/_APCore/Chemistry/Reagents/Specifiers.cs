// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using Content.Shared._APCore.Chemistry.Registry;
using Content.Shared._APCore.Chemistry.Registry.Systems;
using Content.Shared.FixedPoint;

namespace Content.Shared._APCore.Chemistry.Reagents;


[DataDefinition]
public sealed partial class ReagentSpecifier
{
    [DataField(required:true)]
    public string Id;
    private ReagentDefinition? _definition;
    public bool IsValid => _definition != null;

    [DataField]
    public IVariantData? VariantData { get; set; } = null;

    public bool Validate(ChemRegistrySystem registry, bool logMissing = true)
    {
        return registry.TryIndexReagent(Id, out _definition, logMissing);
    }
    public Reagent Read(ChemRegistrySystem registry)
    {
        if (!Validate(registry))
            throw new Exception($"Failed to get resolve with id:{Id}");
        return new Reagent(_definition!, VariantData);
    }
}

[DataDefinition]
public sealed partial class ReagentQuantitySpecifier
{

    [IncludeDataField]
    public ReagentSpecifier Reagent;

    [DataField(required:true)]
    public FixedPoint2 Quantity;
    public bool Validate(ChemRegistrySystem registry, bool logMissing = true)
    {
        return Reagent.Validate(registry, logMissing);
    }
    public ReagentQuantity Read(ChemRegistrySystem registry)
    {
        return new ReagentQuantity(Reagent.Read(registry), Quantity);
    }
}
