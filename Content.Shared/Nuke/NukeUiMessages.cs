// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Nuke
{
    public abstract partial class SharedNukeComponent : Component
    {
        public const string NukeDiskSlotId = "Nuke";
    }

    [Serializable, NetSerializable]
    public sealed class NukeAnchorMessage : BoundUserInterfaceMessage
    {
    }

    [Serializable, NetSerializable]
    public sealed class NukeKeypadMessage : BoundUserInterfaceMessage
    {
        public int Value;

        public NukeKeypadMessage(int value)
        {
            Value = value;
        }
    }

    [Serializable, NetSerializable]
    public sealed class NukeKeypadClearMessage : BoundUserInterfaceMessage
    {
    }

    [Serializable, NetSerializable]
    public sealed class NukeKeypadEnterMessage : BoundUserInterfaceMessage
    {
    }

    [Serializable, NetSerializable]
    public sealed class NukeArmedMessage : BoundUserInterfaceMessage
    {
    }
}
