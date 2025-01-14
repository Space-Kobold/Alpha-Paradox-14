// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Random;
using Content.Shared.Random.Helpers;
using Robust.Shared.Random;

namespace Content.Server.Coordinates;

public sealed class SpawnRandomOffsetSystem : EntitySystem
{
    [Dependency] private readonly RandomHelperSystem _randomHelper = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<SpawnRandomOffsetComponent, MapInitEvent>(OnMapInit);
    }

    private void OnMapInit(EntityUid uid, SpawnRandomOffsetComponent component, MapInitEvent args)
    {
        _randomHelper.RandomOffset(uid, component.Offset);
        EntityManager.RemoveComponentDeferred(uid, component);
    }
}
