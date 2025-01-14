// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Damage;
using Content.Shared.FixedPoint;

namespace Content.Server.Damage.Components;

[RegisterComponent]
public sealed partial class IgniteOnHeatDamageComponent : Component
{
    [DataField("fireStacks")]
    public float FireStacks = 1f;

    // The minimum amount of damage taken to apply fire stacks
    [DataField("threshold")]
    public FixedPoint2 Threshold = 15;
}
