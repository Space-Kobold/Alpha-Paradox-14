// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;

namespace Content.Server.Traits.Assorted;

/// <summary>
/// This is used for the narcolepsy trait.
/// </summary>
[RegisterComponent, Access(typeof(NarcolepsySystem))]
public sealed partial class NarcolepsyComponent : Component
{
    /// <summary>
    /// The random time between incidents, (min, max).
    /// </summary>
    [DataField("timeBetweenIncidents", required: true)]
    public Vector2 TimeBetweenIncidents { get; private set; }

    /// <summary>
    /// The duration of incidents, (min, max).
    /// </summary>
    [DataField("durationOfIncident", required: true)]
    public Vector2 DurationOfIncident { get; private set; }

    public float NextIncidentTime;
}
