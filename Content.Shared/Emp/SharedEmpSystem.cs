// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Timing;

namespace Content.Shared.Emp;

public abstract class SharedEmpSystem : EntitySystem
{
    [Dependency] protected readonly IGameTiming Timing = default!;

    protected const string EmpDisabledEffectPrototype = "EffectEmpDisabled";
}
