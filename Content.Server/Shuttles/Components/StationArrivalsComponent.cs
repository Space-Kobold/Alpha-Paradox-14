// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;
using Robust.Shared.Utility;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// Added to a station that is available for arrivals shuttles.
/// </summary>
[RegisterComponent, Access(typeof(ArrivalsSystem))]
public sealed partial class StationArrivalsComponent : Component
{
    [DataField("shuttle")]
    public EntityUid Shuttle;

    [DataField("shuttlePath")] public ResPath ShuttlePath = new("/Maps/Shuttles/arrivals.yml");
}
