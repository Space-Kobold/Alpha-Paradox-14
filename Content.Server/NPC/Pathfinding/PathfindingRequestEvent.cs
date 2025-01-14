// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;

namespace Content.Server.NPC.Pathfinding;

public sealed class PathfindingRequestEvent : EntityEventArgs
{
    public EntityCoordinates Start;
    public EntityCoordinates End;

    // TODO: Need stuff like can we break shit, can we pry, collision mask, etc
}
