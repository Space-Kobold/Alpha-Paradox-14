// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.CombatMode;
using Robust.Client.Graphics;
using Robust.Client.Input;
using Robust.Client.Player;
using Robust.Shared.Console;
using Robust.Shared.Map;

namespace Content.Client.Weapons.Melee;


public sealed class MeleeSpreadCommand : IConsoleCommand
{
    public string Command => "showmeleespread";
    public string Description => "Shows the current weapon's range and arc for debugging";
    public string Help => $"{Command}";
    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        var collection = IoCManager.Instance;

        if (collection == null)
            return;

        var overlayManager = collection.Resolve<IOverlayManager>();

        if (overlayManager.RemoveOverlay<MeleeArcOverlay>())
        {
            return;
        }

        var sysManager = collection.Resolve<IEntitySystemManager>();

        overlayManager.AddOverlay(new MeleeArcOverlay(
            collection.Resolve<IEntityManager>(),
            collection.Resolve<IEyeManager>(),
            collection.Resolve<IInputManager>(),
            collection.Resolve<IPlayerManager>(),
            sysManager.GetEntitySystem<MeleeWeaponSystem>(),
            sysManager.GetEntitySystem<SharedCombatModeSystem>(),
            sysManager.GetEntitySystem<SharedTransformSystem>()));
    }
}
