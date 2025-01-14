// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Collections;
using System.Linq;
using Robust.Shared.Map;
using Robust.Shared.Random;

namespace Content.Shared.Directions;

public static class SharedDirectionExtensions
{
    public static EntityCoordinates Offset(this EntityCoordinates coordinates, Direction direction)
    {
        return coordinates.Offset(direction.ToVec());
    }
}
