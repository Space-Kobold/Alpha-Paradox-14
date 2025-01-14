// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Containers;

namespace Content.Shared.HotPotato;

public abstract class SharedHotPotatoSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<HotPotatoComponent, ContainerGettingRemovedAttemptEvent>(OnRemoveAttempt);
    }

    private void OnRemoveAttempt(EntityUid uid, HotPotatoComponent comp, ContainerGettingRemovedAttemptEvent args)
    {
        if (!comp.CanTransfer)
            args.Cancel();
    }
}
