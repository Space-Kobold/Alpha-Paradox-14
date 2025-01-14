// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Power.Components;
using Content.Server.Power.EntitySystems;
using Content.Shared.Audio;
using Content.Shared.Mobs;
using Content.Shared.Power;

namespace Content.Server.Audio;

public sealed class AmbientSoundSystem : SharedAmbientSoundSystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<AmbientOnPoweredComponent, PowerChangedEvent>(HandlePowerChange);
        SubscribeLocalEvent<AmbientOnPoweredComponent, PowerNetBatterySupplyEvent>(HandlePowerSupply);
    }

    private void HandlePowerSupply(EntityUid uid, AmbientOnPoweredComponent component, ref PowerNetBatterySupplyEvent args)
    {
        SetAmbience(uid, args.Supply);
    }

    private void HandlePowerChange(EntityUid uid, AmbientOnPoweredComponent component, ref PowerChangedEvent args)
    {
        SetAmbience(uid, args.Powered);
    }
}
