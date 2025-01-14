// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Actions;

/// <summary>
/// Works in tandem with <see cref="ActionGrantComponent"/> by granting those actions to the equipper entity.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, Access(typeof(ActionGrantSystem))]
public sealed partial class ItemActionGrantComponent : Component
{
    [DataField(required: true), AutoNetworkedField, AlwaysPushInheritance]
    public List<EntProtoId> Actions = new();
}
