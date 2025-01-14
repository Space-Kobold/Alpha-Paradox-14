// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.PDA.Ringer
{
    [Serializable, NetSerializable]
    public sealed class RingerUpdateState : BoundUserInterfaceState
    {
        public bool IsPlaying;
        public Note[] Ringtone;

        public RingerUpdateState(bool isPlay, Note[] ringtone)
        {
            IsPlaying = isPlay;
            Ringtone = ringtone;
        }
    }

}
