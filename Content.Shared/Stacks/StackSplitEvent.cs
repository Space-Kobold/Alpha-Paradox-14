// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Stacks;

/// <summary>
///     Raised on the original stack entity when it is split to create another.
/// </summary>
/// <param name="NewId">The entity id of the new stack.</param>
[ByRefEvent]
public readonly record struct StackSplitEvent(EntityUid NewId);
