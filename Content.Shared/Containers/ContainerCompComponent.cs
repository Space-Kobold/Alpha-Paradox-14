// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Containers;

/// <summary>
/// Applies container changes whenever an entity is inserted into the specified container on this entity.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class ContainerCompComponent : Component
{
    [DataField(required: true)]
    public EntProtoId Proto;

    [DataField(required: true)]
    public string Container = string.Empty;
}
