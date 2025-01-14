// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.NPC.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.NPC.Components;

/// <summary>
/// This is used for tracking entities stored in <see cref="FactionExceptionComponent"/>.
/// </summary>
[RegisterComponent, NetworkedComponent, Access(typeof(NpcFactionSystem))]
public sealed partial class FactionExceptionTrackerComponent : Component
{
    /// <summary>
    /// Entities with <see cref="FactionExceptionComponent"/> that are tracking this entity.
    /// </summary>
    [DataField]
    public HashSet<EntityUid> Entities = new();
}
