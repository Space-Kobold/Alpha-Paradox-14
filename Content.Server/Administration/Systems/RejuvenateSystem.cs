// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Rejuvenate;

namespace Content.Server.Administration.Systems;

public sealed class RejuvenateSystem : EntitySystem
{
    public void PerformRejuvenate(EntityUid target)
    {
        RaiseLocalEvent(target, new RejuvenateEvent());
    }
}
