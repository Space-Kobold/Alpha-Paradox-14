// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared.Materials;

/// <summary>
/// Tracker component for the process of reclaiming entities
/// <seealso cref="MaterialReclaimerComponent"/>
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(SharedMaterialReclaimerSystem)), AutoGenerateComponentPause]
public sealed partial class ActiveMaterialReclaimerComponent : Component
{
    /// <summary>
    /// Container used to store the item currently being reclaimed
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public Container ReclaimingContainer = default!;

    /// <summary>
    /// When the reclaiming process ends.
    /// </summary>
    [DataField("endTime", customTypeSerializer: typeof(TimeOffsetSerializer)), ViewVariables(VVAccess.ReadWrite)]
    [AutoPausedField]
    public TimeSpan EndTime;

    /// <summary>
    /// The length of the reclaiming process.
    /// Used for calculations.
    /// </summary>
    [DataField("duration"), ViewVariables(VVAccess.ReadWrite)]
    public TimeSpan Duration;
}
