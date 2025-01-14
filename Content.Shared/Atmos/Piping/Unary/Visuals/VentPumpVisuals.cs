// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Atmos.Visuals
{
    [Serializable, NetSerializable]
    public enum VentPumpVisuals : byte
    {
        State,
    }

    [Serializable, NetSerializable]
    public enum VentPumpState : byte
    {
        Off,
        In,
        Out,
        Welded,
        Lockout,
    }
}
