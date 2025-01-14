// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.NPC.Components;

namespace Content.Server.NPC.Systems;

public sealed partial class NPCPerceptionSystem
{
    /// <summary>
    /// Tracks targets recently injected by medibots.
    /// </summary>
    /// <param name="frameTime"></param>
    private void UpdateRecentlyInjected(float frameTime)
    {
        var query = EntityQueryEnumerator<NPCRecentlyInjectedComponent>();
        while (query.MoveNext(out var uid, out var entity))
        {
            entity.Accumulator += frameTime;
            if (entity.Accumulator < entity.RemoveTime.TotalSeconds)
                continue;
            entity.Accumulator = 0;

            RemComp<NPCRecentlyInjectedComponent>(uid);
        }
    }
}
