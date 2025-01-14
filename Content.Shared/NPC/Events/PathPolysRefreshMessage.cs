// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.NPC;

[Serializable, NetSerializable]
public sealed class PathPolysRefreshMessage : EntityEventArgs
{
    public NetEntity GridUid;
    public Vector2i Origin;

    /// <summary>
    /// Multi-dimension arrays aren't supported so
    /// </summary>
    public Dictionary<Vector2i, List<DebugPathPoly>> Polys = new();
}
