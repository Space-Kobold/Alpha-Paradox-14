// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;

namespace Content.Shared.Construction.Conditions
{
    public interface IConstructionCondition
    {
        ConstructionGuideEntry? GenerateGuideEntry();
        bool Condition(EntityUid user, EntityCoordinates location, Direction direction);
    }
}
