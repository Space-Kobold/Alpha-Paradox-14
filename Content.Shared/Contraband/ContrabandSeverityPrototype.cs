// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Contraband;

/// <summary>
/// This is a prototype for defining the degree of severity for a particular <see cref="ContrabandComponent"/>
/// </summary>
[Prototype]
public sealed partial class ContrabandSeverityPrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    /// <summary>
    /// Text shown for this severity level when the contraband is examined.
    /// </summary>
    [DataField]
    public LocId ExamineText;

    /// <summary>
    /// When examining the contraband, should this take into account the viewer's departments?
    /// </summary>
    [DataField]
    public bool ShowDepartments;
}
