// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// When activated, will shuffle the position of all players
/// within a certain radius.
/// </summary>
[RegisterComponent]
public sealed partial class ShuffleArtifactComponent : Component
{
    [DataField("radius")]
    public float Radius = 7.5f;
}
