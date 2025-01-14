// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Radiation.Events;

/// <summary>
///     Raised on entity when it was irradiated
///     by some radiation source.
/// </summary>
public sealed class OnIrradiatedEvent : EntityEventArgs
{
    public readonly float FrameTime;

    public readonly float RadsPerSecond;

    public float TotalRads => RadsPerSecond * FrameTime;

    public OnIrradiatedEvent(float frameTime, float radsPerSecond)
    {
        FrameTime = frameTime;
        RadsPerSecond = radsPerSecond;
    }
}
