// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Reflect;

/// <summary>
/// Added to an entity if it equips a reflection item in a hand slot or into its clothing.
/// Reflection events will then be relayed.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ReflectUserComponent : Component;
