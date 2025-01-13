// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Console;

namespace Content.Client.Ghost.Commands;

public sealed class ToggleGhostVisibilityCommand : IConsoleCommand
{
    [Dependency] private readonly IEntitySystemManager _entSysMan = default!;

    public string Command => "toggleghostvisibility";
    public string Description => "Toggles ghost visibility on the client.";
    public string Help => "toggleghostvisibility [bool]";

    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var ghostSystem = _entSysMan.GetEntitySystem<GhostSystem>();

        if (args.Length != 0 && bool.TryParse(args[0], out var visibility))
        {
            ghostSystem.ToggleGhostVisibility(visibility);
        }
        else
        {
            ghostSystem.ToggleGhostVisibility();
        }
    }
}
