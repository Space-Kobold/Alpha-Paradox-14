// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.NPC.HTN;
using Robust.Shared.Console;

namespace Content.Client.NPC;

public sealed class ShowHTNCommand : IConsoleCommand
{
    public string Command => "showhtn";
    public string Description => "Shows the current status for HTN NPCs";
    public string Help => $"{Command}";
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var npcs = IoCManager.Resolve<IEntitySystemManager>().GetEntitySystem<HTNSystem>();
        npcs.EnableOverlay ^= true;
    }
}
