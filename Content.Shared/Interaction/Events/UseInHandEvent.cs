// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Clothing.EntitySystems;
using Content.Shared.Timing;
using JetBrains.Annotations;

namespace Content.Shared.Interaction.Events;

/// <summary>
///     Raised when using the entity in your hands.
/// </summary>
[PublicAPI]
public sealed class UseInHandEvent : HandledEntityEventArgs
{
    /// <summary>
    ///     Entity holding the item in their hand.
    /// </summary>
    public EntityUid User;

    /// <summary>
    ///     Whether or not to apply a UseDelay when used.
    ///     Mostly used by the <see cref="ClothingSystem"/> quick-equip to not apply the delay to entities that have the <see cref="UseDelayComponent"/>.
    /// </summary>
    public bool ApplyDelay = true;

    public UseInHandEvent(EntityUid user)
    {
        User = user;
    }
}
