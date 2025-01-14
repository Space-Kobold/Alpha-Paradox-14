// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Stunnable;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, Access(typeof(SharedStunSystem))]
public sealed partial class SlowedDownComponent : Component
{
    [ViewVariables, DataField("sprintSpeedModifier"), AutoNetworkedField]
    public float SprintSpeedModifier = 0.5f;

    [ViewVariables, DataField("walkSpeedModifier"), AutoNetworkedField]
    public float WalkSpeedModifier = 0.5f;
}
