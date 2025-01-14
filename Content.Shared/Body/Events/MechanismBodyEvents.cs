// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Body.Events;

// All of these events are raised on a mechanism entity when added/removed to a body in different
// ways.

/// <summary>
/// Raised on a mechanism when it is added to a body part.
/// </summary>
[ByRefEvent]
public readonly record struct OrganAddedEvent(EntityUid Part);

/// <summary>
/// Raised on a mechanism when it is added to a body part within a body.
/// </summary>
[ByRefEvent]
public readonly record struct OrganAddedToBodyEvent(EntityUid Body, EntityUid Part);

/// <summary>
/// Raised on a mechanism when it is removed from a body part.
/// </summary>
[ByRefEvent]
public readonly record struct OrganRemovedEvent(EntityUid OldPart);

/// <summary>
/// Raised on a mechanism when it is removed from a body part within a body.
/// </summary>
[ByRefEvent]
public readonly record struct OrganRemovedFromBodyEvent(EntityUid OldBody, EntityUid OldPart);
