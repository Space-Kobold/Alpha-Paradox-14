// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Antag.Components;

/// <summary>
/// Spawns this rule's antags at random tiles on a station using <c>TryGetRandomTile</c>.
/// Requires <see cref="AntagSelectionComponent"/>.
/// </summary>
[RegisterComponent]
public sealed partial class AntagRandomSpawnComponent : Component;
