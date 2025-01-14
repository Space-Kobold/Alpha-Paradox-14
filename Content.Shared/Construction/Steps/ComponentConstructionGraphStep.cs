// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Examine;

namespace Content.Shared.Construction.Steps
{
    [DataDefinition]
    public sealed partial class ComponentConstructionGraphStep : ArbitraryInsertConstructionGraphStep
    {
        [DataField("component")] public string Component { get; private set; } = string.Empty;

        public override bool EntityValid(EntityUid uid, IEntityManager entityManager, IComponentFactory compFactory)
        {
            foreach (var component in entityManager.GetComponents(uid))
            {
                if (compFactory.GetComponentName(component.GetType()) == Component)
                    return true;
            }

            return false;
        }

        public override void DoExamine(ExaminedEvent examinedEvent)
        {
            examinedEvent.PushMarkup(string.IsNullOrEmpty(Name)
                ? Loc.GetString(
                    "construction-insert-entity-with-component",
                    ("componentName", Component))// Terrible.
                : Loc.GetString(
                    "construction-insert-exact-entity",
                    ("entityName", Name)));
        }
    }
}
