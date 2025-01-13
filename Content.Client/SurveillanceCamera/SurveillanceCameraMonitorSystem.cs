// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Utility;

namespace Content.Client.SurveillanceCamera;

public sealed class SurveillanceCameraMonitorSystem : EntitySystem
{
    public override void Update(float frameTime)
    {
        var query = EntityQueryEnumerator<ActiveSurveillanceCameraMonitorVisualsComponent>();

        while (query.MoveNext(out var uid, out var comp))
        {
            comp.TimeLeft -= frameTime;

            if (comp.TimeLeft <= 0)
            {
                comp.OnFinish?.Invoke();

                RemCompDeferred<ActiveSurveillanceCameraMonitorVisualsComponent>(uid);
            }
        }
    }

    public void AddTimer(EntityUid uid, Action onFinish)
    {
        var comp = EnsureComp<ActiveSurveillanceCameraMonitorVisualsComponent>(uid);
        comp.OnFinish = onFinish;
    }

    public void RemoveTimer(EntityUid uid)
    {
        RemCompDeferred<ActiveSurveillanceCameraMonitorVisualsComponent>(uid);
    }
}
