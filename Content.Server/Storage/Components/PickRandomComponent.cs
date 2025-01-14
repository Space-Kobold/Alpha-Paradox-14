// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Storage.EntitySystems;
using Content.Shared.Whitelist;

namespace Content.Server.Storage.Components;

/// <summary>
/// Adds a verb to pick a random item from a container.
/// Only picks items that match the whitelist.
/// </summary>
[RegisterComponent]
[Access(typeof(PickRandomSystem))]
public sealed partial class PickRandomComponent : Component
{
    /// <summary>
    /// Whitelist for potential picked items.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public EntityWhitelist? Whitelist;

    /// <summary>
    /// Locale id for the pick verb text.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public LocId VerbText = "comp-pick-random-verb-text";

    /// <summary>
    /// Locale id for the empty storage message.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public LocId EmptyText = "comp-pick-random-empty";
}
