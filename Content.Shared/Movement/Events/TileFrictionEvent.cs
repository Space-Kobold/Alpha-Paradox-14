// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Movement.Events;

/// <summary>
/// Raised to try and get any tile friction modifiers for a particular body.
/// </summary>
[ByRefEvent]
public struct TileFrictionEvent
{
    public float Modifier;

    public TileFrictionEvent(float modifier)
    {
        Modifier = modifier;
    }
}
