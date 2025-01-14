// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Chemistry.EntitySystems;
using Content.Shared.Random;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Chemistry.Components;

/// <summary>
///     Fills a solution container randomly using a weighted random prototype
/// </summary>
[RegisterComponent, Access(typeof(SolutionRandomFillSystem))]
public sealed partial class RandomFillSolutionComponent : Component
{
    /// <summary>
    ///     Solution name which to add reagents to.
    /// </summary>
    [DataField("solution")]
    public string Solution { get; set; } = "default";

    /// <summary>
    ///     Weighted random fill prototype Id. Used to pick reagent and quantity.
    /// </summary>
    [DataField("weightedRandomId", required: true, customTypeSerializer: typeof(PrototypeIdSerializer<WeightedRandomFillSolutionPrototype>))]
    public string? WeightedRandomId;
}
