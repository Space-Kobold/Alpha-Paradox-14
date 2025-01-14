// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.Components
{
    /// <summary>
    /// Interact with to start piloting a shuttle.
    /// </summary>
    [NetworkedComponent]
    public abstract partial class SharedShuttleConsoleComponent : Component
    {
        public static string DiskSlotName = "disk_slot";
    }

    [Serializable, NetSerializable]
    public enum ShuttleConsoleUiKey : byte
    {
        Key,
    }
}
