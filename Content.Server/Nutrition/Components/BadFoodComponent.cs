// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Nutrition.EntitySystems;

namespace Content.Server.Nutrition.Components;

/// <summary>
/// This component prevents NPC mobs like mice from wanting to eat something that is edible but is not exactly food.
/// Including but not limited to: uranium, death pills, insulation
/// </summary>
[RegisterComponent, Access(typeof(FoodSystem))]
public sealed partial class BadFoodComponent : Component
{
}
