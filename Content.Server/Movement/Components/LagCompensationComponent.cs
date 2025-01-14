// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;

namespace Content.Server.Movement.Components;

[RegisterComponent]
public sealed partial class LagCompensationComponent : Component
{
    [ViewVariables]
    public readonly Queue<ValueTuple<TimeSpan, EntityCoordinates, Angle>> Positions = new();
}
