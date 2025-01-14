// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Salvage;

[Prototype]
public sealed partial class SalvageMapPrototype : IPrototype
{
    [ViewVariables] [IdDataField] public string ID { get; } = default!;

    /// <summary>
    /// Relative directory path to the given map, i.e. `Maps/Salvage/template.yml`
    /// </summary>
    [DataField(required: true)] public ResPath MapPath;

    /// <summary>
    /// String that describes the size of the map.
    /// </summary>
    [DataField(required: true)]
    public LocId SizeString;
}
