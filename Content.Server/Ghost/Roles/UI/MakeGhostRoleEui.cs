// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.EUI;
using Content.Shared.Eui;
using Content.Shared.Ghost.Roles;

namespace Content.Server.Ghost.Roles.UI
{
    public sealed class MakeGhostRoleEui : BaseEui
    {
        private IEntityManager _entManager;

        public MakeGhostRoleEui(IEntityManager entManager, NetEntity entity)
        {
            _entManager = entManager;
            Entity = entity;
        }

        public NetEntity Entity { get; }

        public override EuiStateBase GetNewState()
        {
            return new MakeGhostRoleEuiState(Entity);
        }

        public override void Closed()
        {
            base.Closed();

            _entManager.System<GhostRoleSystem>().CloseMakeGhostRoleEui(Player);
        }
    }
}
