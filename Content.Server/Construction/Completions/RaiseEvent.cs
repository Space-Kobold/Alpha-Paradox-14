// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Construction;
using JetBrains.Annotations;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    public sealed partial class RaiseEvent : IGraphAction
    {
        [DataField("event", required:true)]
        public EntityEventArgs? Event { get; private set; }

        [DataField("directed")]
        public bool Directed { get; private set; } = true;

        [DataField("broadcast")]
        public bool Broadcast { get; private set; } = true;

        public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
        {
            if (Event == null || !Directed && !Broadcast)
                return;

            if(Directed)
                entityManager.EventBus.RaiseLocalEvent(uid, (object)Event);

            if(Broadcast)
                entityManager.EventBus.RaiseEvent(EventSource.Local, (object)Event);
        }
    }
}
