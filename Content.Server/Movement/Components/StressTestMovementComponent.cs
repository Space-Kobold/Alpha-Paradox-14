// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;

namespace Content.Server.Movement.Components;

[RegisterComponent]
public sealed partial class StressTestMovementComponent : Component
{
    public float Progress { get; set; }
    public Vector2 Origin { get; set; }
}
