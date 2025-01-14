// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Construction.Components;
using Content.Shared.Construction;
using JetBrains.Annotations;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    [DataDefinition]
    public sealed partial class MachineFrameRegenerateProgress : IGraphAction
    {
        public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
        {
            if (entityManager.TryGetComponent<MachineFrameComponent>(uid, out var machineFrame))
            {
                entityManager.EntitySysManager.GetEntitySystem<MachineFrameSystem>().RegenerateProgress(machineFrame);
            }
        }
    }
}
