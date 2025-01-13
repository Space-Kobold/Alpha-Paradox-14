// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Weapons.Ranged.Systems;
using Robust.Shared.Console;

namespace Content.Client.Weapons.Ranged;

public sealed class ShowSpreadCommand : IConsoleCommand
{
    public string Command => "showgunspread";
    public string Description => $"Shows gun spread overlay for debugging";
    public string Help => $"{Command}";
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var system = IoCManager.Resolve<IEntitySystemManager>().GetEntitySystem<GunSystem>();
        system.SpreadOverlay ^= true;

        shell.WriteLine($"Set spread overlay to {system.SpreadOverlay}");
    }
}
