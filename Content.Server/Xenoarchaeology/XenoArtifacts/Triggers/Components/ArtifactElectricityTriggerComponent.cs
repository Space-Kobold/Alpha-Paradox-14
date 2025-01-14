// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
///     Activate artifact when it contacted with an electricity source.
///     It could be connected MV cables, stun baton or multi tool.
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactElectricityTriggerComponent : Component
{
    /// <summary>
    ///     How much power should artifact receive to operate.
    /// </summary>
    [DataField("minPower")]
    public float MinPower = 400;
}
