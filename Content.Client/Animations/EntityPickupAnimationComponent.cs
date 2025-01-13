// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Animations;

/// <summary>
///     Applied to client-side clone entities to animate them approaching the player that
///     picked up the original entity.
/// </summary>
[RegisterComponent]
[Access(typeof(EntityPickupAnimationSystem))]
public sealed partial class EntityPickupAnimationComponent : Component
{
}
