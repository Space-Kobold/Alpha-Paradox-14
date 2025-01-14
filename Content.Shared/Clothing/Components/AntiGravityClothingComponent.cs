// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Clothing.Components;

/// <summary>
/// This is used for clothing that makes an entity weightless when worn.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class AntiGravityClothingComponent : Component;
