// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.NameIdentifier;

[Prototype("nameIdentifierGroup")]
public sealed partial class NameIdentifierGroupPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     Should the identifier become the full name, or just append?
    /// </summary>
    [DataField("fullName")]
    public bool FullName = false;

    [DataField("prefix")]
    public string? Prefix;

    [DataField("maxValue")]
    public int MaxValue = 1000;

    [DataField("minValue")]
    public int MinValue = 0;
}
