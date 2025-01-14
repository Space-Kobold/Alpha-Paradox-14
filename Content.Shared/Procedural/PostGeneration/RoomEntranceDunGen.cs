// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// Places tiles / entities onto room entrances.
/// </summary>
/// <remarks>
/// DungeonData keys are:
/// - Entrance
/// - FallbackTile
/// </remarks>
public sealed partial class RoomEntranceDunGen : IDunGenLayer;
