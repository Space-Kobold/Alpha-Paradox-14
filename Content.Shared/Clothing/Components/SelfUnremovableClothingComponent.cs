// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Clothing.EntitySystems;
using Robust.Shared.GameStates;

namespace Content.Shared.Clothing.Components;

/// <summary>
///     The component prohibits the player from taking off clothes on them that have this component.
/// </summary>
/// <remarks>
///     See also ClothingComponent.EquipDelay if you want the clothes that the player cannot take off by himself to be put on by the player with a delay.
///</remarks>
[NetworkedComponent]
[RegisterComponent]
[Access(typeof(SelfUnremovableClothingSystem))]
public sealed partial class SelfUnremovableClothingComponent : Component
{

}
