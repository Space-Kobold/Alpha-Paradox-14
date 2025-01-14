// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.GameTicking;

namespace Content.Server.Station.Components;

/// <summary>
///     Added to grids saved in maps to designate that they are the 'main station' grid.
/// </summary>
[RegisterComponent]
[Access(typeof(GameTicker))]
public sealed partial class BecomesStationComponent : Component
{
    /// <summary>
    ///     Mapping only. Should use StationIds in all other
    ///     scenarios.
    /// </summary>
    [DataField("id", required: true)]
    [ViewVariables(VVAccess.ReadWrite)]
    public string Id = default!;
}
