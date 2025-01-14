// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// This is used for using the "knock" spell when the artifact is activated
/// </summary>
[RegisterComponent]
public sealed partial class KnockArtifactComponent : Component
{
    /// <summary>
    /// The range of the spell
    /// </summary>
    [DataField("knockRange")]
    public float KnockRange = 4f;
}
