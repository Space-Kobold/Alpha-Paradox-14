// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Dataset
{
    [Prototype("dataset")]
    public sealed partial class DatasetPrototype : IPrototype
    {
        [ViewVariables]
        [IdDataField]
        public string ID { get; private set; } = default!;

        [DataField("values")] public IReadOnlyList<string> Values { get; private set; } = new List<string>();
    }
}
