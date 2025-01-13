// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.SurveillanceCamera;

namespace Content.Client.SurveillanceCamera;

// Dummy component so that targetted events work on client for
// appearance events.
[RegisterComponent]
public sealed partial class SurveillanceCameraVisualsComponent : Component
{
    [DataField("sprites")]
    public Dictionary<SurveillanceCameraVisuals, string> CameraSprites = new();
}
