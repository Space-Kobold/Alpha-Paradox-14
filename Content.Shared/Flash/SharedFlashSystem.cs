// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Flash.Components;
using Content.Shared.StatusEffect;
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;

namespace Content.Shared.Flash;

public abstract class SharedFlashSystem : EntitySystem
{
    public ProtoId<StatusEffectPrototype> FlashedKey = "Flashed";

    public virtual void FlashArea(Entity<FlashComponent?> source, EntityUid? user, float range, float duration, float slowTo = 0.8f, bool displayPopup = false, float probability = 1f, SoundSpecifier? sound = null)
    {
    }
}
