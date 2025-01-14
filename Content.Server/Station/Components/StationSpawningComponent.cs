// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Station.Systems;

namespace Content.Server.Station.Components;

/// <summary>
/// Controls spawning on the given station, tracking spawners present on it.
/// </summary>
[RegisterComponent, Access(typeof(StationSpawningSystem))]
public sealed partial class StationSpawningComponent : Component
{
}
