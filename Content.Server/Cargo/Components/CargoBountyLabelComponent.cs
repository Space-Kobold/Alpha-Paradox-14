// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Station.Systems;

namespace Content.Server.Cargo.Components;

/// <summary>
/// This is used for marking containers as
/// containing goods for fulfilling bounties.
/// </summary>
[RegisterComponent]
public sealed partial class CargoBountyLabelComponent : Component
{
    /// <summary>
    /// The ID for the bounty this label corresponds to.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public string Id = string.Empty;

    /// <summary>
    /// Used to prevent recursion in calculating the price.
    /// </summary>
    public bool Calculating;

    /// <summary>
    /// The Station System to check and remove bounties from
    /// </summary>
    [DataField]
    public EntityUid? AssociatedStationId;
}
