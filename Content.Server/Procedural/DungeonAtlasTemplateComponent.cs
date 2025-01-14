// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Utility;

namespace Content.Server.Procedural;

/// <summary>
/// Added to pre-loaded maps for dungeon templates.
/// </summary>
[RegisterComponent]
public sealed partial class DungeonAtlasTemplateComponent : Component
{
    [DataField("path", required: true)]
    public ResPath Path;
}
