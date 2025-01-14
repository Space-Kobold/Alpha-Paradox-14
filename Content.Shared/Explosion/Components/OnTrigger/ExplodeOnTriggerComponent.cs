// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Explosion.Components.OnTrigger;

/// <summary>
/// Explode using the entity's <see cref="ExplosiveComponent"/> if Triggered.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ExplodeOnTriggerComponent : Component
{
}
