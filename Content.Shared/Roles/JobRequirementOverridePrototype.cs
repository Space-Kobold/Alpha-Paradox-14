// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Roles;

/// <summary>
/// Collection of job, antag, and ghost-role job requirements for per-server requirement overrides.
/// </summary>
[Prototype]
public sealed partial class JobRequirementOverridePrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    [DataField]
    public Dictionary<ProtoId<JobPrototype>, HashSet<JobRequirement>> Jobs = new ();

    [DataField]
    public Dictionary<ProtoId<AntagPrototype>, HashSet<JobRequirement>> Antags = new ();
}
