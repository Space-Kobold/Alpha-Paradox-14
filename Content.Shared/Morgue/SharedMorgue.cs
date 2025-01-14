// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Morgue;

[Serializable, NetSerializable]
public enum MorgueVisuals : byte
{
    Contents
}

[Serializable, NetSerializable]
public enum MorgueContents : byte
{
    Empty,
    HasMob,
    HasSoul,
    HasContents,
}

[Serializable, NetSerializable]
public enum CrematoriumVisuals : byte
{
    Burning,
}
