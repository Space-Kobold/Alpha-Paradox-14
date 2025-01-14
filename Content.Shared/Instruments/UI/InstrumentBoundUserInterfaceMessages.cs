// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Instruments.UI;

[Serializable, NetSerializable]
public sealed class InstrumentBandRequestBuiMessage : BoundUserInterfaceMessage
{
}

[Serializable, NetSerializable]
public sealed class InstrumentBandResponseBuiMessage : BoundUserInterfaceMessage
{
    public (NetEntity, string)[] Nearby { get; set; }

    public InstrumentBandResponseBuiMessage((NetEntity, string)[] nearby)
    {
        Nearby = nearby;
    }
}
