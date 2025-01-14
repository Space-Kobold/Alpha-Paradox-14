// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Magic.Events;

[ByRefEvent]
public struct BeforeCastSpellEvent(EntityUid performer)
{
    /// <summary>
    /// The Performer of the event, to check if they meet the requirements.
    /// </summary>
    public EntityUid Performer = performer;

    public bool Cancelled;
}
