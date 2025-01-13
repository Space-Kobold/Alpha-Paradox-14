// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Actions;

/// <summary>
///     This event is raised when a user clicks on an empty action slot. Enables other systems to fill this slot.
/// </summary>
public sealed class FillActionSlotEvent : EntityEventArgs
{
    public EntityUid? Action;
}
