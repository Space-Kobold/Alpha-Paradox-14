// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Remote.UI;
using Content.Client.Items;
using Content.Shared.Remotes.EntitySystems;
using Content.Shared.Remotes.Components;

namespace Content.Client.Remotes.EntitySystems;

public sealed class DoorRemoteSystem : SharedDoorRemoteSystem
{
    public override void Initialize()
    {
        base.Initialize();

        Subs.ItemStatus<DoorRemoteComponent>(ent => new DoorRemoteStatusControl(ent));
    }
}
