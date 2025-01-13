// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;

namespace Content.Client.Animations;

/// <summary>
/// Entities with this component tracks the user's world position every frame.
/// </summary>
[RegisterComponent]
public sealed partial class TrackUserComponent : Component
{
    public EntityUid? User;

    /// <summary>
    /// Offset in the direction of the entity's rotation.
    /// </summary>
    public Vector2 Offset = Vector2.Zero;
}
