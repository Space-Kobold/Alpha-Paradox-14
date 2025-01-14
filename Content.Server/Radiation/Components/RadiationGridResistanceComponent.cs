// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Radiation.Systems;

namespace Content.Server.Radiation.Components;

/// <summary>
///     Grid component that stores radiation resistance of <see cref="RadiationBlockerComponent"/> per tile.
/// </summary>
[RegisterComponent]
[Access(typeof(RadiationSystem), Other = AccessPermissions.ReadExecute)]
public sealed partial class RadiationGridResistanceComponent : Component
{
    /// <summary>
    ///     Radiation resistance per tile.
    /// </summary>
    public readonly Dictionary<Vector2i, float> ResistancePerTile = new();
}
