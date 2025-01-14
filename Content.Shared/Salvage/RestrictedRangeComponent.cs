// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Shared.Salvage;

/// <summary>
/// Restricts entities to the specified range on the attached map entity.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class RestrictedRangeComponent : Component
{
    [DataField(required: true), AutoNetworkedField, ViewVariables(VVAccess.ReadWrite)]
    public float Range = 78f;

    [DataField, AutoNetworkedField, ViewVariables(VVAccess.ReadWrite)]
    public Vector2 Origin;

    [DataField]
    public EntityUid BoundaryEntity;
}
