// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.Animations;
using Robust.Client.GameObjects;

namespace Content.Client.Effects;

public sealed class EffectVisualizerSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<EffectVisualsComponent, AnimationCompletedEvent>(OnEffectAnimComplete);
    }

    private void OnEffectAnimComplete(EntityUid uid, EffectVisualsComponent component, AnimationCompletedEvent args)
    {
        QueueDel(uid);
    }
}
