// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Atmos.Piping.Binary.Components
{
    public sealed record GasVolumePumpData(float LastMolesTransferred);

    [Serializable, NetSerializable]
    public enum GasVolumePumpUiKey
    {
        Key,
    }

    [Serializable, NetSerializable]
    public sealed class GasVolumePumpBoundUserInterfaceState : BoundUserInterfaceState
    {
        public string PumpLabel { get; }
        public float TransferRate { get; }
        public bool Enabled { get; }

        public GasVolumePumpBoundUserInterfaceState(string pumpLabel, float transferRate, bool enabled)
        {
            PumpLabel = pumpLabel;
            TransferRate = transferRate;
            Enabled = enabled;
        }
    }

    [Serializable, NetSerializable]
    public sealed class GasVolumePumpToggleStatusMessage : BoundUserInterfaceMessage
    {
        public bool Enabled { get; }

        public GasVolumePumpToggleStatusMessage(bool enabled)
        {
            Enabled = enabled;
        }
    }

    [Serializable, NetSerializable]
    public sealed class GasVolumePumpChangeTransferRateMessage : BoundUserInterfaceMessage
    {
        public float TransferRate { get; }

        public GasVolumePumpChangeTransferRateMessage(float transferRate)
        {
            TransferRate = transferRate;
        }
    }
}
