// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.GameTicking;
using Content.Shared.Administration;
using Content.Shared.GameTicking;
using Robust.Shared.Console;

namespace Content.Server.Administration.Commands
{
    [AdminCommand(AdminFlags.Round)]
    public sealed class ReadyAll : IConsoleCommand
    {
        [Dependency] private readonly IEntityManager _e = default!;

        public string Command => "readyall";
        public string Description => "Readies up all players in the lobby, except for observers.";
        public string Help => $"{Command} | ̣{Command} <ready>";
        public void Execute(IConsoleShell shell, string argStr, string[] args)
        {
            var ready = true;

            if (args.Length > 0)
            {
                ready = bool.Parse(args[0]);
            }

            var gameTicker = _e.System<GameTicker>();


            if (gameTicker.RunLevel != GameRunLevel.PreRoundLobby)
            {
                shell.WriteLine("This command can only be ran while in the lobby!");
                return;
            }

            gameTicker.ToggleReadyAll(ready);
        }
    }
}
