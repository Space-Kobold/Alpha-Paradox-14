// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;
using Robust.Shared.Prototypes;

namespace Content.Shared.Abilities.Goliath;

public sealed partial class GoliathSummonTentacleAction : EntityWorldTargetActionEvent
{
    /// <summary>
    /// The ID of the entity that is spawned.
    /// </summary>
    [DataField]
    public EntProtoId EntityId = "EffectGoliathTentacleSpawn";

    /// <summary>
    /// Directions determining where the entities will spawn.
    /// </summary>
    [DataField]
    public List<Direction> OffsetDirections = new()
    {
        Direction.North,
        Direction.South,
        Direction.East,
        Direction.West,
    };

    /// <summary>
    /// How many entities will spawn beyond the original one at the target location?
    /// </summary>
    [DataField]
    public int ExtraSpawns = 3;
};
