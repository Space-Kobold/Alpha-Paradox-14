// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Effects.Components;

/// <summary>
/// This is used for recharging all nearby batteries when activated
/// </summary>
[RegisterComponent]
public sealed partial class ChargeBatteryArtifactComponent : Component
{
    /// <summary>
    /// The radius of entities that will be affected
    /// </summary>
    [DataField("radius")]
    public float Radius = 15f;
}
