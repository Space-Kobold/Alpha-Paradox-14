// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Anomaly.Effects.Components;

[RegisterComponent, NetworkedComponent, Access(typeof(SharedEntityAnomalySystem))]
public sealed partial class EntitySpawnAnomalyComponent : Component
{
    /// <summary>
    /// All types of entity spawns with their settings
    /// </summary>
    [DataField]
    public List<EntitySpawnSettingsEntry> Entries = new();
}

[DataRecord]
public partial record struct EntitySpawnSettingsEntry()
{
    /// <summary>
    /// A list of entities that are random picked to be spawned on each pulse
    /// </summary>
    public List<EntProtoId> Spawns { get; set; } = new();

    public AnomalySpawnSettings Settings { get; set; } = new();
}
