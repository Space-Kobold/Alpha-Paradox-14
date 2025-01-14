// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Shared.Movement.Events;

/// <summary>
/// Raised directed on an entity when trying to get a relevant footstep sound
/// </summary>
[ByRefEvent]
public record struct GetFootstepSoundEvent(EntityUid User)
{
    public readonly EntityUid User = User;

    /// <summary>
    /// Set the sound to specify a footstep sound and mark as handled.
    /// </summary>
    public SoundSpecifier? Sound;
}
