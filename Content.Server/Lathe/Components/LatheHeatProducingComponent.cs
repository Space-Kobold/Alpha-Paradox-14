// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Lathe;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Server.Lathe.Components;

/// <summary>
/// This is used for a <see cref="LatheComponent"/> that releases heat into the surroundings while producing items.
/// </summary>
[RegisterComponent]
[Access(typeof(LatheSystem))]
public sealed partial class LatheHeatProducingComponent : Component
{
    /// <summary>
    /// The amount of energy produced each second when producing an item.
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float EnergyPerSecond = 30000;

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer))]
    public TimeSpan NextSecond;
}
