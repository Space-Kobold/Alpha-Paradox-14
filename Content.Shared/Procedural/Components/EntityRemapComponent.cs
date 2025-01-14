// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Procedural.Components;

/// <summary>
/// Indicates this entity prototype should be re-mapped to another
/// </summary>
[RegisterComponent]
public sealed partial class EntityRemapComponent : Component
{
    [DataField(required: true)]
    public Dictionary<EntProtoId, EntProtoId> Mask = new();
}
