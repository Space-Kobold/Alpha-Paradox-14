// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Power.Events;

/// <summary>
///     Invoked on a target entity, when it was pulsed with an energy.
///     For instance, interacted with an active stun baton.
/// </summary>
public sealed class PowerPulseEvent : EntityEventArgs
{
    public EntityUid? User;
    public EntityUid? Used;
}
