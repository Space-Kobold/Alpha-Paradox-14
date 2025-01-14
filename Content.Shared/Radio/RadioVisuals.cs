// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Radio;

[Serializable, NetSerializable]
public enum RadioDeviceVisuals : byte
{
    Broadcasting,
    Speaker
}

[Serializable, NetSerializable]
public enum RadioDeviceVisualLayers : byte
{
    Broadcasting,
    Speaker
}
