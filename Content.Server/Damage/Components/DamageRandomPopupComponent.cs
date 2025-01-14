// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Damage.Systems;

namespace Content.Server.Damage.Components;

[RegisterComponent, Access(typeof(DamageRandomPopupSystem))]
/// <summary>
/// Outputs a random pop-up from the list when an object receives damage
/// </summary>
public sealed partial class DamageRandomPopupComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public List<LocId> Popups = new();
}
