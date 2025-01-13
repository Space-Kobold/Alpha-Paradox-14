// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Console;
using Robust.Shared.GameObjects;

namespace Content.Client.Decals;

public sealed class ToggleDecalCommand : IConsoleCommand
{
    [Dependency] private readonly IEntityManager _e = default!;

    public string Command => "toggledecals";
    public string Description => "Toggles decaloverlay";
    public string Help => $"{Command}";
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        _e.System<DecalSystem>().ToggleOverlay();
    }
}
