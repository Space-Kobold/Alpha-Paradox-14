// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Shared.SprayPainter.Prototypes;

/// <summary>
/// Maps airlock style names to department ids.
/// </summary>
[Prototype("airlockDepartments")]
public sealed partial class AirlockDepartmentsPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// Dictionary of style names to department ids.
    /// If a style does not have a department (e.g. external) it is set to null.
    /// </summary>
    [DataField(required: true)]
    public Dictionary<string, ProtoId<DepartmentPrototype>> Departments = new();
}
