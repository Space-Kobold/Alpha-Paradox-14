// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.NPC.Queries.Queries;

public sealed partial class ComponentFilter : UtilityQueryFilter
{
    /// <summary>
    /// Components to filter for.
    /// </summary>
    [DataField("components", required: true)]
    public ComponentRegistry Components = new();
}
