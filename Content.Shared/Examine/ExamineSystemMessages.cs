// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Verbs;
using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared.Examine
{
    public static class ExamineSystemMessages
    {
        [Serializable, NetSerializable]
        public sealed class RequestExamineInfoMessage : EntityEventArgs
        {
            public readonly NetEntity NetEntity;

            public readonly int Id;

            public readonly bool GetVerbs;

            public RequestExamineInfoMessage(NetEntity netEntity, int id, bool getVerbs=false)
            {
                NetEntity = netEntity;
                Id = id;
                GetVerbs = getVerbs;
            }
        }

        [Serializable, NetSerializable]
        public sealed class ExamineInfoResponseMessage : EntityEventArgs
        {
            public readonly NetEntity EntityUid;
            public readonly int Id;
            public readonly FormattedMessage Message;

            public List<Verb>? Verbs;

            public readonly bool CenterAtCursor;
            public readonly bool OpenAtOldTooltip;

            public readonly bool KnowTarget;

            public ExamineInfoResponseMessage(NetEntity entityUid, int id, FormattedMessage message, List<Verb>? verbs=null,
                bool centerAtCursor=true, bool openAtOldTooltip=true, bool knowTarget = true)
            {
                EntityUid = entityUid;
                Id = id;
                Message = message;
                Verbs = verbs;
                CenterAtCursor = centerAtCursor;
                OpenAtOldTooltip = openAtOldTooltip;
                KnowTarget = knowTarget;
            }
        }
    }
}
