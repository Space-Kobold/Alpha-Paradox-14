// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Client.Markers;
using Content.Client.Popups;
using Content.Client.SubFloor;
using Content.Shared.SubFloor;
using Robust.Client.GameObjects;
using Robust.Shared.Console;
using DrawDepth = Content.Shared.DrawDepth.DrawDepth;

namespace Content.Client.Commands;

internal sealed class ShowMarkersCommand : LocalizedCommands
{
    [Dependency] private readonly IEntitySystemManager _entitySystemManager = default!;

    public override string Command => "showmarkers";

    public override string Help => LocalizationManager.GetString($"cmd-{Command}-help", ("command", Command));

    public override void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        _entitySystemManager.GetEntitySystem<MarkerSystem>().MarkersVisible ^= true;
    }
}

internal sealed class ShowSubFloor : LocalizedCommands
{
    [Dependency] private readonly IEntitySystemManager _entitySystemManager = default!;

    public override string Command => "showsubfloor";

    public override string Help => LocalizationManager.GetString($"cmd-{Command}-help", ("command", Command));

    public override void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        _entitySystemManager.GetEntitySystem<SubFloorHideSystem>().ShowAll ^= true;
    }
}

internal sealed class ShowSubFloorForever : LocalizedCommands
{
    [Dependency] private readonly IEntitySystemManager _entitySystemManager = default!;

    public const string CommandName = "showsubfloorforever";
    public override string Command => CommandName;

    public override string Help => LocalizationManager.GetString($"cmd-{Command}-help", ("command", Command));

    public override void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        _entitySystemManager.GetEntitySystem<SubFloorHideSystem>().ShowAll = true;

        var entMan = IoCManager.Resolve<IEntityManager>();
        var components = entMan.EntityQuery<SubFloorHideComponent, SpriteComponent>(true);

        foreach (var (_, sprite) in components)
        {
            sprite.DrawDepth = (int) DrawDepth.Overlays;
        }
    }
}

internal sealed class NotifyCommand : LocalizedCommands
{
    [Dependency] private readonly IEntitySystemManager _entitySystemManager = default!;

    public override string Command => "notify";

    public override string Help => LocalizationManager.GetString($"cmd-{Command}-help", ("command", Command));

    public override void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var message = args[0];

        _entitySystemManager.GetEntitySystem<PopupSystem>().PopupCursor(message);
    }
}
