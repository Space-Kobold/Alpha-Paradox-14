// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Diagnostics.CodeAnalysis;
using Content.Shared.Power.Components;

namespace Content.Shared.Power.EntitySystems;

public abstract class SharedPowerReceiverSystem : EntitySystem
{
    public abstract bool ResolveApc(EntityUid entity, [NotNullWhen(true)] ref SharedApcPowerReceiverComponent? component);

    /// <summary>
    /// Checks if entity is APC-powered device, and if it have power.
    /// </summary>
    public bool IsPowered(Entity<SharedApcPowerReceiverComponent?> entity)
    {
        if (!ResolveApc(entity.Owner, ref entity.Comp))
            return true;

        return entity.Comp.Powered;
    }

    protected string GetExamineText(bool powered)
    {
        return Loc.GetString("power-receiver-component-on-examine-main",
                                ("stateText", Loc.GetString(powered
                                    ? "power-receiver-component-on-examine-powered"
                                    : "power-receiver-component-on-examine-unpowered")));
    }
}
