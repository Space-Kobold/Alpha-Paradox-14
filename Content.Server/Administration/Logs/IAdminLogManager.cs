// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Text.Json;
using System.Threading.Tasks;
using Content.Server.Database;
using Content.Server.GameTicking;
using Content.Shared.Administration.Logs;

namespace Content.Server.Administration.Logs;

public interface IAdminLogManager : ISharedAdminLogManager
{
    void Initialize();
    Task Shutdown();
    void Update();

    void RoundStarting(int id);
    void RunLevelChanged(GameRunLevel level);

    Task<List<SharedAdminLog>> All(LogFilter? filter = null, Func<List<SharedAdminLog>>? listProvider = null);
    IAsyncEnumerable<string> AllMessages(LogFilter? filter = null);
    IAsyncEnumerable<JsonDocument> AllJson(LogFilter? filter = null);
    Task<Round> Round(int roundId);
    Task<List<SharedAdminLog>> CurrentRoundLogs(LogFilter? filter = null);
    IAsyncEnumerable<string> CurrentRoundMessages(LogFilter? filter = null);
    IAsyncEnumerable<JsonDocument> CurrentRoundJson(LogFilter? filter = null);
    Task<Round> CurrentRound();
    Task<int> CountLogs(int round);
}
