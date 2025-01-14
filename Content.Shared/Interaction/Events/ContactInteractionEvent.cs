// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Interaction.Events;

/// <summary>
///     Raised directed at two entities to indicate that they came into contact, usually as a result of some other interaction.
/// </summary>
/// <remarks>
///     This is currently used by the forensics and disease systems to perform on-contact interactions.
/// </remarks>
public sealed class ContactInteractionEvent : HandledEntityEventArgs
{
    public EntityUid Other;

    public ContactInteractionEvent(EntityUid other)
    {
        Other = other;
    }
}
