// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Access.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Access.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(ActivatableUIRequiresAccessSystem))]
public sealed partial class ActivatableUIRequiresAccessComponent : Component
{
    [DataField]
    public LocId? PopupMessage = "lock-comp-has-user-access-fail";
}
