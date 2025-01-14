// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Storage.EntitySystems;
using Robust.Shared.GameStates;

namespace Content.Shared.Storage.Components;

// TODO:
// REPLACE THIS WITH CONTAINERFILL
[RegisterComponent, NetworkedComponent, Access(typeof(SharedStorageSystem))]
public sealed partial class StorageFillComponent : Component
{
    [DataField("contents")] public List<EntitySpawnEntry> Contents = new();
}
