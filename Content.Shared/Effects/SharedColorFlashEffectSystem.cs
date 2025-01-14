// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Player;

namespace Content.Shared.Effects;

public abstract class SharedColorFlashEffectSystem : EntitySystem
{
    public abstract void RaiseEffect(Color color, List<EntityUid> entities, Filter filter);
}
