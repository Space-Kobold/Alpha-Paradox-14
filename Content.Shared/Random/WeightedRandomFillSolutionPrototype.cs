// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Random;

/// <summary>
///     Random weighting dataset for solutions, able to specify reagents quantity.
/// </summary>
[Prototype("weightedRandomFillSolution")]
public sealed partial class WeightedRandomFillSolutionPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = default!;

    /// <summary>
    ///     List of RandomFills that can be picked from.
    /// </summary>
    [DataField("fills", required: true)]
    public List<RandomFillSolution> Fills = new();
}
