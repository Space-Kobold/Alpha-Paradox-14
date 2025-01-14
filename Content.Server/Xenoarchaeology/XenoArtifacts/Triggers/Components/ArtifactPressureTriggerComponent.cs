// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
/// Triggers when a certain pressure threshold is hit
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactPressureTriggerComponent : Component
{
    /// <summary>
    /// The lower-end pressure threshold
    /// </summary>
    [DataField("minPressureThreshold")]
    public float? MinPressureThreshold;

    /// <summary>
    /// The higher-end pressure threshold
    /// </summary>
    [DataField("maxPressureThreshold")]
    public float? MaxPressureThreshold;
}
