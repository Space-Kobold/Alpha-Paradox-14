// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using JetBrains.Annotations;

namespace Content.Server.Tabletop
{
    [UsedImplicitly]
    public sealed partial class TabletopEmptySetup : TabletopSetup
    {
        public override void SetupTabletop(TabletopSession session, IEntityManager entityManager)
        {
            var board = entityManager.SpawnEntity(BoardPrototype, session.Position.Offset(0, 0));
            session.Entities.Add(board);
        }
    }
}
