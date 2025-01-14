// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Standing;
using Robust.Shared.Containers;

namespace Content.Shared.Medical.Cryogenics;

public abstract partial class SharedCryoPodSystem
{
    public virtual void InitializeInsideCryoPod()
    {
        SubscribeLocalEvent<InsideCryoPodComponent, DownAttemptEvent>(HandleDown);
        SubscribeLocalEvent<InsideCryoPodComponent, EntGotRemovedFromContainerMessage>(OnEntGotRemovedFromContainer);
    }

    // Must stand in the cryo pod
    private void HandleDown(EntityUid uid, InsideCryoPodComponent component, DownAttemptEvent args)
    {
        args.Cancel();
    }

    private void OnEntGotRemovedFromContainer(EntityUid uid, InsideCryoPodComponent component, EntGotRemovedFromContainerMessage args)
    {
        if (Terminating(uid))
        {
            return;
        }

        RemComp<InsideCryoPodComponent>(uid);
    }
}
