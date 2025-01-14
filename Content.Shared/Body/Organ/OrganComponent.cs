// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Body.Systems;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;

namespace Content.Shared.Body.Organ;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedBodySystem))]
public sealed partial class OrganComponent : Component
{
    /// <summary>
    /// Relevant body this organ is attached to.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? Body;
}
