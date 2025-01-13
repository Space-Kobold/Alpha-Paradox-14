// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Singularity.EntitySystems;
using Content.Shared.Singularity.Components;

namespace Content.Client.Singularity.Systems;

/// <summary>
/// The client-side version of <see cref="SharedSingularityGeneratorSystem"/>.
/// Manages <see cref="SingularityGeneratorComponent"/>s.
/// Exists to make relevant signal handlers (ie: <see cref="SharedSingularityGeneratorSystem.OnEmagged"/>) work on the client.
/// </summary>
public sealed class SingularityGeneratorSystem : SharedSingularityGeneratorSystem
{}
