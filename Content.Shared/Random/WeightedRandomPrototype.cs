// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Random;

/// <summary>
/// Generic random weighting dataset to use.
/// </summary>
[Prototype("weightedRandom")]
public sealed class WeightedRandomPrototype : IWeightedRandomPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("weights")]
    public Dictionary<string, float> Weights { get; private set; } = new();
}
