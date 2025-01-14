// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Examine;

namespace Content.Shared.Construction.Steps
{
    [Serializable]
    [ImplicitDataDefinitionForInheritors]
    public abstract partial class ConstructionGraphStep
    {
        [DataField("completed", serverOnly: true)] private IGraphAction[] _completed = Array.Empty<IGraphAction>();

        [DataField("doAfter")] public float DoAfter { get; private set; }

        public IReadOnlyList<IGraphAction> Completed => _completed;

        public abstract void DoExamine(ExaminedEvent examinedEvent);
        public abstract ConstructionGuideEntry GenerateGuideEntry();
    }
}
