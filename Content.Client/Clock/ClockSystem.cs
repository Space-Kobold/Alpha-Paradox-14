// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Clock;
using Robust.Client.GameObjects;

namespace Content.Client.Clock;

public sealed class ClockSystem : SharedClockSystem
{
    public override void Update(float frameTime)
    {
        base.Update(frameTime);

        var query = EntityQueryEnumerator<ClockComponent, SpriteComponent>();
        while (query.MoveNext(out var uid, out var comp, out var sprite))
        {
            if (!sprite.LayerMapTryGet(ClockVisualLayers.HourHand, out var hourLayer) ||
                !sprite.LayerMapTryGet(ClockVisualLayers.MinuteHand, out var minuteLayer))
                continue;

            var time = GetClockTime((uid, comp));
            var hourState = $"{comp.HoursBase}{time.Hours % 12}";
            var minuteState = $"{comp.MinutesBase}{time.Minutes / 5}";
            sprite.LayerSetState(hourLayer, hourState);
            sprite.LayerSetState(minuteLayer, minuteState);
        }
    }
}
