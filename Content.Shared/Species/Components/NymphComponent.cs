// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.GameStates;

namespace Content.Shared.Species.Components;
/// <summary>
/// This will replace one entity with another entity when it is removed from a body part.
/// Obviously hyper-specific. If you somehow find another use for this, good on you. 
/// </summary>

[RegisterComponent, NetworkedComponent]
public sealed partial class NymphComponent : Component
{
    /// <summary>
    /// The entity to replace the organ with.
    /// </summary>
    [DataField(required: true)]
    public EntProtoId EntityPrototype = default!;

    /// <summary>
    /// Whether to transfer the mind to this new entity.
    /// </summary>
    [DataField]
    public bool TransferMind = false;
}
