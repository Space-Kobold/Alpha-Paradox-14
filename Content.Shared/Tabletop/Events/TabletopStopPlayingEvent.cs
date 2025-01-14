// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Tabletop.Events
{
    /// <summary>
    /// An event ot tell the server that we have stopped playing this tabletop game.
    /// </summary>
    [Serializable, NetSerializable]
    public sealed class TabletopStopPlayingEvent : EntityEventArgs
    {
        /// <summary>
        /// The entity UID of the table associated with this tabletop game.
        /// </summary>
        public NetEntity TableUid;

        public TabletopStopPlayingEvent(NetEntity tableUid)
        {
            TableUid = tableUid;
        }
    }
}
