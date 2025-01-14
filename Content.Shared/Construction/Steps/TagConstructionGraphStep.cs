// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Tag;

namespace Content.Shared.Construction.Steps
{
    [DataDefinition]
    public sealed partial class TagConstructionGraphStep : ArbitraryInsertConstructionGraphStep
    {
        [DataField("tag")]
        private string? _tag;

        public override bool EntityValid(EntityUid uid, IEntityManager entityManager, IComponentFactory compFactory)
        {
            var tagSystem = entityManager.EntitySysManager.GetEntitySystem<TagSystem>();
            return !string.IsNullOrEmpty(_tag) && tagSystem.HasTag(uid, _tag);
        }
    }
}
