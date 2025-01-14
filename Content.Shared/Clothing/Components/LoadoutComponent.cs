// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Preferences.Loadouts;
using Content.Shared.Roles;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Clothing.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class LoadoutComponent : Component
{
    /// <summary>
    /// A list of starting gears, of which one will be given, before RoleLoadouts are equipped.
    /// All elements are weighted the same in the list.
    /// </summary>
    [DataField("prototypes")]
    [AutoNetworkedField]
    public List<ProtoId<StartingGearPrototype>>? StartingGear;

    /// <summary>
    /// A list of role loadouts, of which one will be given.
    /// All elements are weighted the same in the list.
    /// </summary>
    [DataField]
    [AutoNetworkedField]
    public List<ProtoId<RoleLoadoutPrototype>>? RoleLoadout;
}
