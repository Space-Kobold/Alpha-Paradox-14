// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Light
{
    [Serializable, NetSerializable]
    public enum PoweredLightVisuals : byte
    {
        BulbState,
        Blinking
    }

    [Serializable, NetSerializable]
    public enum PoweredLightState : byte
    {
        Empty,
        On,
        Off,
        Broken,
        Burned
    }

    public enum PoweredLightLayers : byte
    {
        Base,
        Glow
    }
}
