// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Pulling.Events;

/// <summary>
/// Raised when a request is made to stop pulling an entity.
/// </summary>
public record struct AttemptStopPullingEvent(EntityUid? User = null)
{
    public readonly EntityUid? User = User;
    public bool Cancelled;
}