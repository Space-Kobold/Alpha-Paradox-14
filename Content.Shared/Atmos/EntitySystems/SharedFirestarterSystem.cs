// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;
using Content.Shared.Atmos.Components;

namespace Content.Shared.Atmos.EntitySystems;

public abstract class SharedFirestarterSystem : EntitySystem
{
    [Dependency] private readonly SharedActionsSystem _actionsSystem = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<FirestarterComponent, ComponentInit>(OnComponentInit);
    }

    /// <summary>
    /// Adds the firestarter action.
    /// </summary>
    private void OnComponentInit(EntityUid uid, FirestarterComponent component, ComponentInit args)
    {
        _actionsSystem.AddAction(uid, ref component.FireStarterActionEntity, component.FireStarterAction, uid);
        Dirty(uid, component);
    }
}
