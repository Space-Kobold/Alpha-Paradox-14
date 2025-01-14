// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Nutrition.EntitySystems;
using Content.Shared.Nutrition.Prototypes;
using Content.Shared.Tag;
using Robust.Shared.Prototypes;

namespace Content.Shared.Nutrition.Components;

/// <summary>
/// Indicates that this entity can be inserted into FoodSequence, which will transfer all reagents to the target.
/// </summary>
[RegisterComponent, Access(typeof(SharedFoodSequenceSystem))]
public sealed partial class FoodSequenceElementComponent : Component
{
    /// <summary>
    /// The same object can be used in different sequences, and it will have a different data in then.
    /// </summary>
    [DataField(required: true)]
    public Dictionary<ProtoId<TagPrototype>, ProtoId<FoodSequenceElementPrototype>> Entries = new();

    /// <summary>
    /// Which solution we will add to the main dish
    /// </summary>
    [DataField]
    public string Solution = "food";
}
