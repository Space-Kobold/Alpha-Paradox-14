// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Forensics.Components;

/// <summary>
/// This component is for entities we do not wish to track fingerprints/fibers, like puddles
/// </summary>
[RegisterComponent]
public sealed partial class IgnoresFingerprintsComponent : Component { }
