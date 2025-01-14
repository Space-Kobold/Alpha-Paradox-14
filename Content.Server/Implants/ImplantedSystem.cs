// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Implants.Components;
using Robust.Shared.Containers;

namespace Content.Server.Implants;

public sealed partial class ImplanterSystem
{
    public void InitializeImplanted()
    {
        SubscribeLocalEvent<ImplantedComponent, ComponentInit>(OnImplantedInit);
        SubscribeLocalEvent<ImplantedComponent, ComponentShutdown>(OnShutdown);
    }

    private void OnImplantedInit(EntityUid uid, ImplantedComponent component, ComponentInit args)
    {
        component.ImplantContainer = _container.EnsureContainer<Container>(uid, ImplanterComponent.ImplantSlotId);
        component.ImplantContainer.OccludesLight = false;
    }

    private void OnShutdown(EntityUid uid, ImplantedComponent component, ComponentShutdown args)
    {
        //If the entity is deleted, get rid of the implants
        _container.CleanContainer(component.ImplantContainer);
    }
}
