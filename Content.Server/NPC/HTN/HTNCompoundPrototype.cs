// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.NPC.HTN;

/// <summary>
/// Represents a network of multiple tasks. This gets expanded out to its relevant nodes.
/// </summary>
[Prototype("htnCompound")]
public sealed partial class HTNCompoundPrototype : IPrototype
{
    [IdDataField] public string ID { get; } = string.Empty;

    [DataField("branches", required: true)]
    public List<HTNBranch> Branches = new();

    /// <summary>
    /// Exclude this compound task from the CompoundRecursion integration test.
    /// </summary>
    [DataField]
    public bool AllowRecursion = false;
}
