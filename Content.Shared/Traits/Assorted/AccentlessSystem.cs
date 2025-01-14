// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization.Manager;

namespace Content.Shared.Traits.Assorted;

/// <summary>
/// This handles removing accents when using the accentless trait.
/// </summary>
public sealed class AccentlessSystem : EntitySystem
{
    /// <inheritdoc/>
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<AccentlessComponent, ComponentStartup>(RemoveAccents);
    }

    private void RemoveAccents(EntityUid uid, AccentlessComponent component, ComponentStartup args)
    {
        foreach (var accent in component.RemovedAccents.Values)
        {
            var accentComponent = accent.Component;
            RemComp(uid, accentComponent.GetType());
        }
    }
}
