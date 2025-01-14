// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Construction
{
    [ImplicitDataDefinitionForInheritors]
    public partial interface IGraphAction
    {
        // TODO pass in node/edge & graph ID for better error logs.
        void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager);
    }
}
