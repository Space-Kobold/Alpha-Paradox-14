// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Explosion.Components;

/// <summary>
///     Component for tracking active trigger timers. A timers can activated by some other component, e.g. <see cref="OnUseTimerTriggerComponent"/>.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ActiveTimerTriggerComponent : Component
{
    [DataField] public float TimeRemaining;

    [DataField] public EntityUid? User;

    [DataField] public float BeepInterval;

    [DataField] public float TimeUntilBeep;

    [DataField] public SoundSpecifier? BeepSound;
}
