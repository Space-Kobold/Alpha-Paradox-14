// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Diagnostics;
using Content.Server.Administration;
using Content.Server.Chat.V2.Repository;
using Content.Shared.Administration;
using Robust.Shared.Toolshed;
using Robust.Shared.Toolshed.Errors;
using Robust.Shared.Utility;

namespace Content.Server.Chat.V2.Commands;

[ToolshedCommand, AdminCommand(AdminFlags.Admin)]
public sealed class NukeChatMessagesCommand : ToolshedCommand
{
    [Dependency] private readonly IEntitySystemManager _manager = default!;

    [CommandImplementation("usernames")]
    public void Command(IInvocationContext ctx, string usernamesCsv)
    {
        var usernames = usernamesCsv.Split(',');

        foreach (var username in usernames)
        {
            if (!_manager.GetEntitySystem<ChatRepositorySystem>().NukeForUsername(username, out var reason))
            {
                ctx.ReportError(new NukeMessagesForUsernameError(reason));
            }
        }
    }
}

public record struct NukeMessagesForUsernameError(string Reason) : IConError
{
    public FormattedMessage DescribeInner()
    {
        return FormattedMessage.FromUnformatted(Reason);
    }

    public string? Expression { get; set; }
    public Vector2i? IssueSpan { get; set; }
    public StackTrace? Trace { get; set; }
}
