// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
/// Triggers when a nearby entity dies
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactDeathTriggerComponent : Component
{
    /// <summary>
    /// How close to the death the artifact has to be for it to trigger.
    /// </summary>
    [DataField("range")]
    public float Range = 15f;
}
