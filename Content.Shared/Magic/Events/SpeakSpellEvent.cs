// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Magic.Events;

[ByRefEvent]
public readonly struct SpeakSpellEvent(EntityUid performer, string speech)
{
    public readonly EntityUid Performer = performer;
    public readonly string Speech = speech;
}
