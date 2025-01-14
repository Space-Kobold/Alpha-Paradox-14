// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Chemistry.Components;

/// <summary>
/// This is used for entities which are currently being affected by smoke.
/// Manages the gradual metabolism every second.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentPause]
public sealed partial class SmokeAffectedComponent : Component
{
    /// <summary>
    /// The time at which the next smoke metabolism will occur.
    /// </summary>
    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    [AutoPausedField]
    public TimeSpan NextSecond;

    /// <summary>
    /// The smoke that is currently affecting this entity.
    /// </summary>
    [DataField]
    public EntityUid SmokeEntity;
}
