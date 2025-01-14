// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.StatusEffect;

namespace Content.Shared.Drowsiness;

public abstract class SharedDrowsinessSystem : EntitySystem
{
    [ValidatePrototypeId<StatusEffectPrototype>]
    public const string DrowsinessKey = "Drowsiness";
}
