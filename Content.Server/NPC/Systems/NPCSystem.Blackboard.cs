// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.NPC.HTN;

namespace Content.Server.NPC.Systems;

public sealed partial class NPCSystem
{
    public void SetBlackboard(EntityUid uid, string key, object value, HTNComponent? component = null)
    {
        if (!Resolve(uid, ref component, false))
        {
            return;
        }

        var blackboard = component.Blackboard;
        blackboard.SetValue(key, value);
    }
}
