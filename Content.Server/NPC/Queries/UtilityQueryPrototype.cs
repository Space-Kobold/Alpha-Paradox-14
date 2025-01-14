// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.NPC.Queries.Considerations;
using Content.Server.NPC.Queries.Queries;
using Robust.Shared.Prototypes;

namespace Content.Server.NPC.Queries;

/// <summary>
/// Stores data for generic queries.
/// Each query is run in turn to get the final available results.
/// These results are then run through the considerations.
/// </summary>
[Prototype("utilityQuery")]
public sealed partial class UtilityQueryPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    [ViewVariables(VVAccess.ReadWrite), DataField("query")]
    public List<UtilityQuery> Query = new();

    [ViewVariables(VVAccess.ReadWrite), DataField("considerations")]
    public List<UtilityConsideration> Considerations = new();

    /// <summary>
    /// How many entities we are allowed to consider. This is applied after all queries have run.
    /// </summary>
    [DataField("limit")]
    public int Limit = 128;
}
