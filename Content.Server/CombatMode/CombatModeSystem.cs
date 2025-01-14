// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.NPC.HTN;
using Content.Shared.CombatMode;

namespace Content.Server.CombatMode;

public sealed class CombatModeSystem : SharedCombatModeSystem
{
    protected override bool IsNpc(EntityUid uid)
    {
        return HasComp<HTNComponent>(uid);
    }
}
