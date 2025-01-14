// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// Places the specified entities on the middle connections between rooms
/// </summary>
public sealed partial class MiddleConnectionDunGen : IDunGenLayer
{
    /// <summary>
    /// How much overlap there needs to be between 2 rooms exactly.
    /// </summary>
    [DataField]
    public int OverlapCount = -1;

    /// <summary>
    /// How many connections to spawn between rooms.
    /// </summary>
    [DataField]
    public int Count = 1;
}
