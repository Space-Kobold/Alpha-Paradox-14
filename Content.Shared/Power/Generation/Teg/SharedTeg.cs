// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Power.Generation.Teg;

/// <summary>
/// Appearance keys for the TEG &amp; its circulators.
/// </summary>
[Serializable, NetSerializable]
public enum TegVisuals
{
    PowerOutput,
    CirculatorSpeed,
    CirculatorPower,
}

/// <summary>
/// Visual sprite layers for the TEG &amp; its circulators.
/// </summary>
[Serializable, NetSerializable]
public enum TegVisualLayers
{
    PowerOutput,
    CirculatorBase,
    CirculatorLight
}

/// <summary>
/// Visual speed levels for the TEG circulators.
/// </summary>
[Serializable, NetSerializable]
public enum TegCirculatorSpeed
{
    SpeedStill,
    SpeedSlow,
    SpeedFast
}
