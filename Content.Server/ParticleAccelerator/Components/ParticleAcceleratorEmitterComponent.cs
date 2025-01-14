// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Server.ParticleAccelerator.Components;

[RegisterComponent]
public sealed partial class ParticleAcceleratorEmitterComponent : Component
{
    [DataField]
    public EntProtoId EmittedPrototype = "ParticlesProjectile";

    [DataField("emitterType")]
    [ViewVariables(VVAccess.ReadWrite)]
    public ParticleAcceleratorEmitterType Type = ParticleAcceleratorEmitterType.Fore;

    public override string ToString()
    {
        return base.ToString() + $" EmitterType:{Type}";
    }
}

public enum ParticleAcceleratorEmitterType
{
    Port,
    Fore,
    Starboard
}
