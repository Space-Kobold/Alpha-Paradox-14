// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.FixedPoint;
using Robust.Shared.Serialization;

namespace Content.Shared.Chemistry
{
    [Serializable, NetSerializable]
    public sealed class TransferAmountBoundInterfaceState : BoundUserInterfaceState
    {
        public FixedPoint2 Max;
        public FixedPoint2 Min;

        public TransferAmountBoundInterfaceState(FixedPoint2 max, FixedPoint2 min)
        {
            Max = max;
            Min = min;
        }
    }

    [Serializable, NetSerializable]
    public sealed class TransferAmountSetValueMessage : BoundUserInterfaceMessage
    {
        public FixedPoint2 Value;

        public TransferAmountSetValueMessage(FixedPoint2 value)
        {
            Value = value;
        }
    }

    [Serializable, NetSerializable]
    public enum TransferAmountUiKey
    {
        Key,
    }
}
