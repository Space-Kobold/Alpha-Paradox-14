// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Alert;

/// <summary>
///     Raised when the AlertSystem needs alert sources to recalculate their alert states and set them.
/// </summary>
public sealed class AlertSyncEvent : EntityEventArgs
{
    public EntityUid Euid { get; }

    public AlertSyncEvent(EntityUid euid)
    {
        Euid = euid;
    }
}
