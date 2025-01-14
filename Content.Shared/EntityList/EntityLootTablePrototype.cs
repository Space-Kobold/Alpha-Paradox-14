// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections.Immutable;
using Content.Shared.Storage;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Shared.EntityList;

[Prototype("entityLootTable")]
public sealed partial class EntityLootTablePrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField("entries")]
    public ImmutableList<EntitySpawnEntry> Entries = ImmutableList<EntitySpawnEntry>.Empty;

    /// <inheritdoc cref="EntitySpawnCollection.GetSpawns"/>
    public List<string> GetSpawns(IRobustRandom random)
    {
        return EntitySpawnCollection.GetSpawns(Entries, random);
    }
}
