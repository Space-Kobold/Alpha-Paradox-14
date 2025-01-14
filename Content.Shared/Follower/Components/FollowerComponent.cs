// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Follower.Components;

[RegisterComponent]
[Access(typeof(FollowerSystem))]
[NetworkedComponent, AutoGenerateComponentState]
public sealed partial class FollowerComponent : Component
{
    [AutoNetworkedField, DataField("following")]
    public EntityUid Following;
}
