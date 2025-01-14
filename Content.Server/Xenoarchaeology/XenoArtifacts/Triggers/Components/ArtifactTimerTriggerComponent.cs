// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Xenoarchaeology.XenoArtifacts.Triggers.Components;

/// <summary>
///     Will try to activate artifact periodically.
///     Doesn't used for random artifacts, can be spawned by admins.
/// </summary>
[RegisterComponent]
public sealed partial class ArtifactTimerTriggerComponent : Component
{
    /// <summary>
    ///     Time between artifact activation attempts.
    /// </summary>
    [DataField("rate")]
    [ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan ActivationRate = TimeSpan.FromSeconds(5.0f);

    /// <summary>
    ///     Last time when artifact was activated.
    /// </summary>
    public TimeSpan LastActivation;
}
