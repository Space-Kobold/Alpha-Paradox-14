// SPDX-FileCopyrightText: 2025 Space Kobold Games and Contributors
// SPDX-License-Identifier: MPL-2.0-no-copyleft-exception

using System.Collections.Frozen;
using Content.Shared.Body.Prototypes;
using Content.Shared.Chemistry.Reaction;
using Content.Shared.Chemistry.Reagent;
using Content.Shared.EntityEffects;
using Content.Shared.FixedPoint;
using Content.Shared.Nutrition;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;
using ReactiveReagentEffectEntry = Content.Shared.Chemistry.Reagent.ReactiveReagentEffectEntry;

namespace Content.Shared._APCore.Chemistry.Registry;

[DataDefinition] [Virtual] [Serializable] [NetSerializable]
public partial class ReagentDefinition
{
    [DataField]
    public string Id { get; private set; } = default!;

    [DataField(required: true)]
    private LocId Name { get; set; }

    [ViewVariables(VVAccess.ReadOnly)]
    public string LocalizedName => Loc.GetString(Name);

    [DataField]
    public string Group { get; private set; } = "Unknown";

    [DataField("desc", required: true)]
    private LocId Description { get; set; }

    [ViewVariables(VVAccess.ReadOnly)]
    public string LocalizedDescription => Loc.GetString(Description);

    [DataField("physicalDesc", required: true)]
    private LocId PhysicalDescription { get; set; }

    [ViewVariables(VVAccess.ReadOnly)]
    public string LocalizedPhysicalDescription => Loc.GetString(PhysicalDescription);

    [DataField("color")]
    public Color SubstanceColor { get; private set; } = Color.White;

    /// <summary>
    ///     The specific heat of the reagent.
    ///     How much energy it takes to heat one unit of this reagent by one Kelvin.
    /// </summary>
    [DataField]
    public float SpecificHeat { get; private set; } = 1.0f;

    [DataField]
    public float? BoilingPoint { get; private set; }

    [DataField]
    public float? MeltingPoint { get; private set; }

    [DataField]
    public SpriteSpecifier? MetamorphicSprite { get; private set; }

    [DataField]
    public int MetamorphicMaxFillLevels { get; private set; }

    [DataField]
    public string? MetamorphicFillBaseName { get; private set; }

    [DataField]
    public bool MetamorphicChangeColor { get; private set; } = true;
    /// <summary>
    ///     How easily this reagent becomes fizzy when aggitated.
    ///     0 - completely flat, 1 - fizzes up when nudged.
    /// </summary>
    [DataField]
    public float Fizziness;

    [DataField]
    public ProtoId<FlavorPrototype>? Flavor;

    /// <summary>
    ///     There must be at least this much quantity in a solution to be tasted.
    /// </summary>
    [DataField]
    public FixedPoint2 FlavorMinimum = FixedPoint2.New(0.1f);

    [DataField]
    public float PricePerUnit;

    /// <summary>
    ///     Is this reagent recognizable to the average spaceman (water, welding fuel, ketchup, etc)?
    /// </summary>
    [DataField]
    public bool Recognizable;

    /// <summary>
    ///     If this reagent is part of a puddle is it slippery.
    /// </summary>
    [DataField]
    public bool Slippery;

    /// <summary>
    ///     How much reagent slows entities down if it's part of a puddle.
    ///     0 - no slowdown; 1 - can't move.
    /// </summary>
    [DataField]
    public float Viscosity;

    /// <summary>
    ///     Should this reagent work on the dead?
    /// </summary>
    [DataField]
    public bool WorksOnTheDead;

    [DataField(serverOnly: true)] [NonSerialized]
    public List<ITileReaction> TileReactions = new(0);

    [DataField][NonSerialized]
    public SoundSpecifier FootstepSound =
        new SoundCollectionSpecifier("FootstepWater", AudioParams.Default.WithVolume(6));

    [DataField(serverOnly: true)][NonSerialized]
    public FrozenDictionary<ProtoId<MetabolismGroupPrototype>, ReagentEffectsEntry>? Metabolisms;

    [DataField("plantMetabolism", serverOnly: true)][NonSerialized]
    public List<EntityEffect> PlantMetabolisms = new(0);

    [DataField(serverOnly: true)][NonSerialized]
    public Dictionary<ProtoId<ReactiveGroupPrototype>, ReactiveReagentEffectEntry>? ReactiveEffects;
}
