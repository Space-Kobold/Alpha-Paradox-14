// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Movement.Systems;
using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared.Movement.Components;

[NetworkedComponent, RegisterComponent]
[AutoGenerateComponentState]
[Access(typeof(SpeedModifierContactsSystem))]
public sealed partial class SpeedModifierContactsComponent : Component
{
    [DataField("walkSpeedModifier"), ViewVariables(VVAccess.ReadWrite)]
    [AutoNetworkedField]
    public float WalkSpeedModifier = 1.0f;

    [AutoNetworkedField]
    [DataField("sprintSpeedModifier"), ViewVariables(VVAccess.ReadWrite)]
    public float SprintSpeedModifier = 1.0f;

    [DataField("ignoreWhitelist")]
    public EntityWhitelist? IgnoreWhitelist;
}
