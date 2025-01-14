// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Storage.Components
{
    [Serializable, NetSerializable]
    public enum SharedBagOpenVisuals : byte
    {
        BagState,
    }

    [Serializable, NetSerializable]
    public enum SharedBagState : byte
    {
        Open,
        Closed,
    }
}
