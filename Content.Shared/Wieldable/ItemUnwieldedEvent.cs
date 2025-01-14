// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Wieldable;

#region Events

/// <summary>
///     Raised on the item that has been unwielded.
/// </summary>
public sealed class ItemUnwieldedEvent : EntityEventArgs
{
    public EntityUid? User;
    /// <summary>
    ///     Whether the item is being forced to be unwielded, or if the player chose to unwield it themselves.
    /// </summary>
    public bool Force;

    public ItemUnwieldedEvent(EntityUid? user = null, bool force=false)
    {
        User = user;
        Force = force;
    }
}

#endregion
