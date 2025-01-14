// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;
using Robust.Shared.Utility;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// Spawns Central Command (emergency destination) for a station.
/// </summary>
[RegisterComponent]
public sealed partial class StationCentcommComponent : Component
{
    /// <summary>
    /// Crude shuttle offset spawning.
    /// </summary>
    [DataField]
    public float ShuttleIndex;

    [DataField]
    public ResPath Map = new("/Maps/centcomm.yml");

    /// <summary>
    /// Centcomm entity that was loaded.
    /// </summary>
    [DataField]
    public EntityUid? Entity;

    [DataField]
    public EntityUid? MapEntity;
}
