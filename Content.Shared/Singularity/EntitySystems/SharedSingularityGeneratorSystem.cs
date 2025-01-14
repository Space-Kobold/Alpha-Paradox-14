// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Emag.Systems;
using Content.Shared.Popups;
using Content.Shared.Singularity.Components;

namespace Content.Shared.Singularity.EntitySystems;

/// <summary>
/// Shared part of SingularitySingularityGeneratorSystem
/// </summary>
public abstract class SharedSingularityGeneratorSystem : EntitySystem
{
    #region Dependencies
    [Dependency] protected readonly SharedPopupSystem PopupSystem = default!;
    #endregion Dependencies

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SingularityGeneratorComponent, GotEmaggedEvent>(OnEmagged);
    }

    private void OnEmagged(EntityUid uid, SingularityGeneratorComponent component, ref GotEmaggedEvent args)
    {
        component.FailsafeDisabled = true;
        args.Handled = true;
    }
}