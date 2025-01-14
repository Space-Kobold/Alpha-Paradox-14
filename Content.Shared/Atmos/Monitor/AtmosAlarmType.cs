// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Atmos.Monitor;

[Serializable, NetSerializable]
public enum AtmosAlarmType : sbyte
{
    Invalid = 0,
    Normal = 1,
    Warning = 2,
    Danger = 3,
    Emagged = 4,
}
