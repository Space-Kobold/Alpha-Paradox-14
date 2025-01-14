// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// Selects [count] rooms and places external doors to them.
/// </summary>
/// <remarks>
/// Dungeon data keys are:
/// - Entrance
/// - FallbackTile
/// </remarks>
public sealed partial class DungeonEntranceDunGen : IDunGenLayer
{
    /// <summary>
    /// How many rooms we place doors on.
    /// </summary>
    [DataField]
    public int Count = 1;
}
