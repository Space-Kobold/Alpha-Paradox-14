// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Research.Prototypes;
using Robust.Shared.Prototypes;

namespace Content.Shared.Lathe.Prototypes;

/// <summary>
/// This is a prototype for a category for <see cref="LatheRecipePrototype"/>
/// </summary>
[Prototype]
public sealed partial class LatheCategoryPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    /// <summary>
    /// A localized string used in the UI
    /// </summary>
    [DataField]
    public LocId Name;
}
