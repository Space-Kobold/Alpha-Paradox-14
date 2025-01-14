// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Content.Shared.Humanoid;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Prototypes;

namespace Content.Shared.Whistle;

/// <summary>
/// Spawn attached entity for entities in range with <see cref="HumanoidAppearanceComponent"/>.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class WhistleComponent : Component
{
    /// <summary>
    /// Entity prototype to spawn
    /// </summary>
    [DataField]
    public EntProtoId Effect = "WhistleExclamation";

    /// <summary>
    /// Range value.
    /// </summary>
    [DataField]
    public float Distance = 0;
}
