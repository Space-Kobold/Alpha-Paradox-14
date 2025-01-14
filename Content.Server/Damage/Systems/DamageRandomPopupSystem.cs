// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Damage.Components;
using Content.Server.Popups;
using Content.Shared.Damage;
using Robust.Shared.Player;
using Robust.Shared.Random;

namespace Content.Server.Damage.Systems;

/// <summary>
/// Outputs a random pop-up from the strings list when an object receives damage
/// </summary>
public sealed class DamageRandomPopupSystem : EntitySystem
{
    [Dependency] private readonly PopupSystem _popupSystem = default!;
    [Dependency] private readonly IRobustRandom _random = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<DamageRandomPopupComponent, DamageChangedEvent>(OnDamageChange);
    }

    private void OnDamageChange(EntityUid uid, DamageRandomPopupComponent component, DamageChangedEvent args)
    {
        _popupSystem.PopupEntity(Loc.GetString(_random.Pick(component.Popups)), uid);
    }
}
