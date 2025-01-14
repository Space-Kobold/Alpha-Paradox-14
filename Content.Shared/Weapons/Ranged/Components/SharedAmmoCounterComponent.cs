// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Weapons.Ranged.Components;

/// <summary>
/// Shows an ItemStatus with the ammo of the gun. Adjusts based on what the ammoprovider is.
/// </summary>
[NetworkedComponent]
public abstract partial class SharedAmmoCounterComponent : Component {}
