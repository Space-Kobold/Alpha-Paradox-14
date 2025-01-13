// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.GPS.Components;
using Content.Client.GPS.UI;
using Content.Client.Items;

namespace Content.Client.GPS.Systems;

public sealed class HandheldGpsSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        Subs.ItemStatus<HandheldGPSComponent>(ent => new HandheldGpsStatusControl(ent));
    }
}
