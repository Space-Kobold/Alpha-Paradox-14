// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Body.Components;
using Content.Shared.Morgue.Components;
using Content.Shared.Standing;
using Content.Shared.Storage.Components;

namespace Content.Shared.Morgue;

public sealed class EntityStorageLayingDownOverrideSystem : EntitySystem
{
    [Dependency] private readonly StandingStateSystem _standing = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<EntityStorageLayingDownOverrideComponent, StorageBeforeCloseEvent>(OnBeforeClose);
    }

    private void OnBeforeClose(EntityUid uid, EntityStorageLayingDownOverrideComponent component, ref StorageBeforeCloseEvent args)
    {
        foreach (var ent in args.Contents)
        {
            if (HasComp<BodyComponent>(ent) && !_standing.IsDown(ent))
                args.Contents.Remove(ent);
        }
    }
}
