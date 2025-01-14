// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Interaction.Events;

/// <summary>
/// Raised on the target when failing to pet/hug something.
/// </summary>
// TODO INTERACTION
// Rename this, or move it to another namespace to make it clearer that this is specific to "petting/hugging" (InteractionPopupSystem)
[ByRefEvent]
public readonly record struct InteractionFailureEvent(EntityUid User);
