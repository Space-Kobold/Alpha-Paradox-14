// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Friends.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Friends.Components;

/// <summary>
/// Pet something to become friends with it (use in hand, press Z)
/// Requires this entity to have FactionExceptionComponent to work.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(PettableFriendSystem))]
public sealed partial class PettableFriendComponent : Component
{
    /// <summary>
    /// Localized popup sent when petting for the first time
    /// </summary>
    [DataField(required: true)]
    public LocId SuccessString = string.Empty;

    /// <summary>
    /// Localized popup sent when petting multiple times
    /// </summary>
    [DataField(required: true)]
    public LocId FailureString = string.Empty;
}
