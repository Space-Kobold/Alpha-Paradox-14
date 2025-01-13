// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Chemistry.Visualizers;

/// <summary>
/// A component that changes color to match its contained reagents.
/// Managed by <see cref="SmokeVisualizerSystem"/>.
/// Only functions with smoke at the moment.
/// </summary>
[RegisterComponent]
[Access(typeof(SmokeVisualizerSystem))]
public sealed partial class SmokeVisualsComponent : Component {}
