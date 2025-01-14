// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Actions;
using Content.Shared.DeviceNetwork.Components;
using Content.Shared.UserInterface;
using Robust.Shared.Serialization;

namespace Content.Shared.DeviceNetwork.Systems;

public abstract class SharedNetworkConfiguratorSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<NetworkConfiguratorComponent, ActivatableUIOpenAttemptEvent>(OnUiOpenAttempt);
    }

    private void OnUiOpenAttempt(EntityUid uid, NetworkConfiguratorComponent configurator, ActivatableUIOpenAttemptEvent args)
    {
        if (configurator.LinkModeActive)
            args.Cancel();
    }
}

public sealed partial class ClearAllOverlaysEvent : InstantActionEvent
{
}

[Serializable, NetSerializable]
public enum NetworkConfiguratorVisuals
{
    Mode
}

[Serializable, NetSerializable]
public enum NetworkConfiguratorLayers
{
    ModeLight
}
