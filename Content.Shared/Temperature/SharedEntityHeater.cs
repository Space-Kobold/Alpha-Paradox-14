// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Temperature;

[Serializable, NetSerializable]
public enum EntityHeaterVisuals
{
    Setting
}

/// <summary>
/// What heat the heater is set to, if on at all.
/// </summary>
[Serializable, NetSerializable]
public enum EntityHeaterSetting
{
    Off,
    Low,
    Medium,
    High
}
