using Content.Shared.Materials;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using ReagentId = Content.Shared._APCore.Chemistry.Reagents.ReagentId;

namespace Content.Server.Materials.Components;

/// <summary>
/// This is used for a machine that turns produce into a specified material.
/// </summary>
[RegisterComponent, Access(typeof(ProduceMaterialExtractorSystem))]
public sealed partial class ProduceMaterialExtractorComponent : Component
{
    /// <summary>
    /// The material that produce is converted into
    /// </summary>
    [DataField]
    public ProtoId<MaterialPrototype> ExtractedMaterial = "Biomass";

    /// <summary>
    /// List of reagents that determines how much material is yielded from a produce.
    /// </summary>
    [DataField]
    public List<ReagentId> ExtractionReagents = new()
    {
        "Nutriment"
    };

    [DataField]
    public SoundSpecifier? ExtractSound = new SoundPathSpecifier("/Audio/Effects/waterswirl.ogg");
}
