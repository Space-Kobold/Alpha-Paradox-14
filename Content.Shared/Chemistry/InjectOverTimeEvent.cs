// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Chemistry.Events;

/// <summary>
/// Raised directed on an entity when it embeds in another entity.
/// </summary>
[ByRefEvent]
public readonly record struct InjectOverTimeEvent(EntityUid embeddedIntoUid)
{
    /// <summary>
    /// Entity that is embedded in.
    /// </summary>
    public readonly EntityUid EmbeddedIntoUid = embeddedIntoUid;
}
