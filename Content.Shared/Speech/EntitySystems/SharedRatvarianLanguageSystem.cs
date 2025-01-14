// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.StatusEffect;

namespace Content.Shared.Speech.EntitySystems;

public abstract class SharedRatvarianLanguageSystem : EntitySystem
{
    public virtual void DoRatvarian(EntityUid uid, TimeSpan time, bool refresh, StatusEffectsComponent? status = null)
    {
    }
}
