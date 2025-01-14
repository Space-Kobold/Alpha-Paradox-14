// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Storage;

namespace Content.Server.Tools.Innate
{
    [RegisterComponent]
    public sealed partial class InnateToolComponent : Component
    {
        [DataField("tools")] public List<EntitySpawnEntry> Tools = new();
        public List<EntityUid> ToolUids = new();
        public List<string> ToSpawn = new();
    }
}
