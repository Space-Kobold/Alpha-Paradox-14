// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.PostGeneration;

/// <summary>
/// Connects dungeons via points that get subdivided.
/// </summary>
public sealed partial class SplineDungeonConnectorDunGen : IDunGenLayer
{
    /// <summary>
    /// Will divide the distance between the start and end points so that no subdivision is more than these metres away.
    /// </summary>
    [DataField]
    public int DivisionDistance = 10;

    /// <summary>
    /// How much each subdivision can vary from the middle.
    /// </summary>
    [DataField]
    public float VarianceMax = 0.35f;
}
