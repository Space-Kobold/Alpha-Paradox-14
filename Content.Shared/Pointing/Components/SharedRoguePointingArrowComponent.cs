// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Pointing.Components
{
    [NetworkedComponent]
    public abstract partial class SharedRoguePointingArrowComponent : Component
    {
    }

    [Serializable, NetSerializable]
    public enum RoguePointingArrowVisuals : byte
    {
        Rotation
    }
}
