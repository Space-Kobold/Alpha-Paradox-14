// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
/// Triggers when the salvage magnet is activated
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactMagnetTriggerComponent : Component
{
    /// <summary>
    /// how close to the magnet do you have to be?
    /// </summary>
    [DataField("range")]
    public float Range = 40f;

    /// <summary>
    /// How close do active magboots have to be?
    /// This is smaller because they are weaker magnets
    /// </summary>
    [DataField("magbootRange")]
    public float MagbootRange = 2f;
}
