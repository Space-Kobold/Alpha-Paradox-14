// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.EntityTable.EntitySelectors;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Shared.EntityTable;

public sealed class EntityTableSystem : EntitySystem
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;
    [Dependency] private readonly IRobustRandom _random = default!;

    public IEnumerable<EntProtoId> GetSpawns(EntityTableSelector? table, System.Random? rand = null)
    {
        if (table == null)
            return new List<EntProtoId>();

        rand ??= _random.GetRandom();
        return table.GetSpawns(rand, EntityManager, _prototypeManager);
    }
}
