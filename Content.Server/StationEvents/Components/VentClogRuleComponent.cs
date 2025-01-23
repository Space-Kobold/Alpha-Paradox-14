﻿using Content.Server.StationEvents.Events;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Audio;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;
using ReagentId = Content.Shared._APCore.Chemistry.Reagents.ReagentId;

namespace Content.Server.StationEvents.Components;

[RegisterComponent, Access(typeof(VentClogRule))]
public sealed partial class VentClogRuleComponent : Component
{
    /// <summary>
    /// Somewhat safe chemicals to put in foam that probably won't instantly kill you.
    /// There is a small chance of using any reagent, ignoring this.
    /// </summary>
    [DataField]
    public IReadOnlyList<ReagentId> SafeishVentChemicals = new[]
    {
        new ReagentId("Water"), new ReagentId("Blood"), new ReagentId("Slime"), new ReagentId("SpaceDrugs"),
        new ReagentId("SpaceCleaner"), new ReagentId("Nutriment"), new ReagentId("Sugar"), new ReagentId("SpaceLube"),
        new ReagentId("Ephedrine"), new ReagentId("Ale"), new ReagentId("Beer"), new ReagentId("SpaceGlue")
    };

    /// <summary>
    /// Sound played when foam is being created.
    /// </summary>
    [DataField]
    public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/Effects/extinguish.ogg");

    /// <summary>
    /// The standard reagent quantity to put in the foam, modified by event severity.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int ReagentQuantity = 100;

    /// <summary>
    /// The standard spreading of the foam, not modified by event severity.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int Spread = 16;

    /// <summary>
    /// How long the foam lasts for
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float Time = 20f;

    /// <summary>
    /// Reagents that gets the weak numbers used instead of regular ones.
    /// </summary>
    [DataField]
    public IReadOnlyList<ReagentId> WeakReagents = new[]
    {
        new ReagentId("SpaceLube"), new ReagentId("SpaceGlue")
    };

    /// <summary>
    /// Quantity of weak reagents to put in the foam.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int WeakReagentQuantity = 50;

    /// <summary>
    /// Spread of the foam for weak reagents.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int WeakSpread = 3;
}
