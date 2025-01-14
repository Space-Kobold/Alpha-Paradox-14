// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Systems;
using Content.Shared.Chemistry.Components;
using Content.Shared.Chemistry.Reagent;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.List;

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// This is used for an artifact that creates a puddle of
/// random chemicals upon being triggered.
/// </summary>
[RegisterComponent, Access(typeof(ChemicalPuddleArtifactSystem))]
public sealed partial class ChemicalPuddleArtifactComponent : Component
{
    /// <summary>
    /// The solution where all the chemicals are stored
    /// </summary>
    [DataField("chemicalSolution", required: true), ViewVariables(VVAccess.ReadWrite)]
    public Solution ChemicalSolution = default!;

    /// <summary>
    /// The different chemicals that can be spawned by this effect
    /// </summary>
    [DataField("possibleChemicals", required: true, customTypeSerializer: typeof(PrototypeIdListSerializer<ReagentPrototype>))]
    public List<string> PossibleChemicals = default!;

    /// <summary>
    /// The number of chemicals in the puddle
    /// </summary>
    [DataField("chemAmount")]
    public int ChemAmount = 3;
}
