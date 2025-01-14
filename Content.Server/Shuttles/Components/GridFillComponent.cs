// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Server.Shuttles.Components;

/// <summary>
/// If added to an airlock will try to autofill a grid onto it on MapInit
/// </summary>
[RegisterComponent, Access(typeof(ShuttleSystem))]
public sealed partial class GridFillComponent : Component
{
    [DataField]
    public ResPath Path = new("/Maps/Shuttles/escape_pod_small.yml");

    /// <summary>
    /// Components to be added to any spawned grids.
    /// </summary>
    [DataField]
    public ComponentRegistry AddComponents = new();
}
