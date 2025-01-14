// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Construction.Steps
{
    [ImplicitDataDefinitionForInheritors]
    public abstract partial class EntityInsertConstructionGraphStep : ConstructionGraphStep
    {
        [DataField("store")] public string Store { get; private set; } = string.Empty;

        public abstract bool EntityValid(EntityUid uid, IEntityManager entityManager, IComponentFactory compFactory);
    }
}
