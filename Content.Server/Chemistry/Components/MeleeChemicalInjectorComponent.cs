// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Chemistry.Components;

/// <summary>
/// Used for melee weapon entities that should try to inject a
/// contained solution into a target when used to hit it.
/// </summary>
[RegisterComponent]
public sealed partial class MeleeChemicalInjectorComponent : BaseSolutionInjectOnEventComponent { }
