// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Trigger
{
    [Serializable, NetSerializable]
    public enum ProximityTriggerVisuals : byte
    {
        Off,
        Inactive,
        Active,
    }

    [Serializable, NetSerializable]
    public enum ProximityTriggerVisualState : byte
    {
        State,
    }

    [Serializable, NetSerializable]
    public enum TriggerVisuals : byte
    {
        VisualState,
    }

    [Serializable, NetSerializable]
    public enum TriggerVisualState : byte
    {
        Primed,
        Unprimed,
    }
}
