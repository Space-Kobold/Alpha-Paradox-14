// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Alert;
using Robust.Client.GameObjects;

namespace Content.Client.Alerts;

/// <summary>
/// Event raised on an entity with alerts in order to allow it to update visuals for the alert sprite entity.
/// </summary>
[ByRefEvent]
public record struct UpdateAlertSpriteEvent
{
    public Entity<SpriteComponent> SpriteViewEnt;

    public AlertPrototype Alert;

    public UpdateAlertSpriteEvent(Entity<SpriteComponent> spriteViewEnt, AlertPrototype alert)
    {
        SpriteViewEnt = spriteViewEnt;
        Alert = alert;
    }
}
