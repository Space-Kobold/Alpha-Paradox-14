// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.Components;

namespace Content.Server.Power.EntitySystems;

public static class StaticPowerSystem
{
    // Using this makes the call shorter.
    // ReSharper disable once UnusedParameter.Global
    public static bool IsPowered(this EntitySystem system, EntityUid uid, IEntityManager entManager, ApcPowerReceiverComponent? receiver = null)
    {
        if (receiver == null && !entManager.TryGetComponent(uid, out receiver))
            return true;

        return receiver.Powered;
    }
}
