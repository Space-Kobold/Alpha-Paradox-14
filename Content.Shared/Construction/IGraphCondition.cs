// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Examine;

namespace Content.Shared.Construction
{
    [ImplicitDataDefinitionForInheritors]
    public partial interface IGraphCondition
    {
        bool Condition(EntityUid uid, IEntityManager entityManager);
        bool DoExamine(ExaminedEvent args);
        IEnumerable<ConstructionGuideEntry> GenerateGuideEntry();
    }
}
