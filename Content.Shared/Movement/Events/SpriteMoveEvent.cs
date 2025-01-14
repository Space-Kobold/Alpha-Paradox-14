// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Movement.Events;

/// <summary>
/// Raised on an entity whenever it should change movement sprite
/// </summary>
[ByRefEvent]
public readonly struct SpriteMoveEvent
{
    public readonly bool IsMoving = false;

    public SpriteMoveEvent(bool isMoving)
    {
        IsMoving = isMoving;
    }
}
