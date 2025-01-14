// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Physics.Events;

namespace Content.Shared.Physics;

public sealed class SharedPreventCollideSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PreventCollideComponent, PreventCollideEvent>(OnPreventCollide);
    }

    private void OnPreventCollide(EntityUid uid, PreventCollideComponent component, ref PreventCollideEvent args)
    {
        if (component.Uid == args.OtherEntity)
            args.Cancelled = true;
    }

}
