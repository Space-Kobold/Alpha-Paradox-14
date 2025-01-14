// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.NPC;

[Serializable, NetSerializable]
public sealed class PathBreadcrumbsMessage : EntityEventArgs
{
    public Dictionary<NetEntity, Dictionary<Vector2i, List<PathfindingBreadcrumb>>> Breadcrumbs = new();
}

[Serializable, NetSerializable]
public sealed class PathBreadcrumbsRefreshMessage : EntityEventArgs
{
    public NetEntity GridUid;
    public Vector2i Origin;
    public List<PathfindingBreadcrumb> Data = new();
}

[Serializable, NetSerializable]
public sealed class PathPolysMessage : EntityEventArgs
{
    public Dictionary<NetEntity, Dictionary<Vector2i, Dictionary<Vector2i, List<DebugPathPoly>>>> Polys = new();
}
