// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// Added to a designated arrivals station for players to spawn at, if enabled.
/// </summary>
[RegisterComponent, Access(typeof(ArrivalsSystem))]
public sealed partial class ArrivalsSourceComponent : Component
{

}
