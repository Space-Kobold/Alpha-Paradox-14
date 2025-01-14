// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Anomaly;
using Robust.Shared.Audio;

namespace Content.Server.Anomaly.Components;

/// <summary>
/// This is used for scanning anomalies and
/// displaying information about them in the ui
/// </summary>
[RegisterComponent, Access(typeof(SharedAnomalySystem))]
public sealed partial class AnomalyScannerComponent : Component
{
    /// <summary>
    /// The anomaly that was last scanned by this scanner.
    /// </summary>
    [ViewVariables]
    public EntityUid? ScannedAnomaly;

    /// <summary>
    /// How long the scan takes
    /// </summary>
    [DataField("scanDoAfterDuration")]
    public float ScanDoAfterDuration = 5;

    /// <summary>
    /// The sound plays when the scan finished
    /// </summary>
    [DataField("completeSound")]
    public SoundSpecifier? CompleteSound = new SoundPathSpecifier("/Audio/Items/beep.ogg");
}
