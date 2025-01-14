// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Station.Components;
using Robust.Shared.Console;

namespace Content.Server.Commands;

/// <summary>
/// Helper functions for programming console command completions.
/// </summary>
public static class ContentCompletionHelper
{
    /// <summary>
    /// Return all stations, with their ID as value and name as hint.
    /// </summary>
    public static IEnumerable<CompletionOption> StationIds(IEntityManager entityManager)
    {
        var query = entityManager.EntityQueryEnumerator<StationDataComponent, MetaDataComponent>();
        while (query.MoveNext(out var uid, out _, out var metaData))
        {
            yield return new CompletionOption(uid.ToString(), metaData.EntityName);
        }
    }
}
