// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos.EntitySystems;

namespace Content.Server.Atmos.Components;

[RegisterComponent]
[Access(typeof(BarotraumaSystem))]
public sealed partial class PressureProtectionComponent : Component
{
    [DataField]
    public float HighPressureMultiplier = 1f;

    [DataField]
    public float HighPressureModifier;

    [DataField]
    public float LowPressureMultiplier = 1f;

    [DataField]
    public float LowPressureModifier;
}

/// <summary>
/// Event raised on an entity with <see cref="PressureProtectionComponent"/> in order to adjust its default values.
/// </summary>
[ByRefEvent]
public record struct GetPressureProtectionValuesEvent
{
    public float HighPressureMultiplier;
    public float HighPressureModifier;
    public float LowPressureMultiplier;
    public float LowPressureModifier;
}

