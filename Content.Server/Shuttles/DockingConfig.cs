// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Components;
using Robust.Shared.Map;

namespace Content.Server.Shuttles;

/// <summary>
/// Stores the data for a valid docking configuration for the emergency shuttle
/// </summary>
public sealed class DockingConfig
{
    /// <summary>
    /// The pairs of docks that can connect.
    /// </summary>
    public List<(EntityUid DockAUid, EntityUid DockBUid, DockingComponent DockA, DockingComponent DockB)> Docks = new();

    /// <summary>
    /// Target grid for docking.
    /// </summary>
    public EntityUid TargetGrid;

    /// <summary>
    /// This is used for debugging.
    /// </summary>
    public Box2 Area;

    public EntityCoordinates Coordinates;
    public Angle Angle;
}
