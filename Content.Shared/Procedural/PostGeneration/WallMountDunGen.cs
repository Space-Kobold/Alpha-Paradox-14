// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// Spawns on the boundary tiles of rooms.
/// </summary>
public sealed partial class WallMountDunGen : IDunGenLayer
{
    /// <summary>
    /// Chance per free tile to spawn a wallmount.
    /// </summary>
    [DataField]
    public double Prob = 0.1;
}
