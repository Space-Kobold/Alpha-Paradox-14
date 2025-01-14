// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.PDA.Ringer
{

    [Serializable, NetSerializable]
    public sealed class RingerRequestUpdateInterfaceMessage : BoundUserInterfaceMessage
    {
    }

    [Serializable, NetSerializable]
    public sealed class RingerPlayRingtoneMessage : BoundUserInterfaceMessage
    {
    }

    [Serializable, NetSerializable]
    public sealed class RingerSetRingtoneMessage : BoundUserInterfaceMessage
    {
        public Note[] Ringtone { get; }

        public RingerSetRingtoneMessage(Note[] ringTone)
        {
            Ringtone = ringTone;
        }
    }
}
