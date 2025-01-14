// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Nutrition.EntitySystems;

namespace Content.Server.Nutrition.Components;

/// <summary>
/// This component prevents NPC mobs like mice or cows from wanting to drink something that shouldn't be drank from.
/// Including but not limited to: puddles
/// </summary>
[RegisterComponent, Access(typeof(DrinkSystem))]
public sealed partial class BadDrinkComponent : Component
{
}
