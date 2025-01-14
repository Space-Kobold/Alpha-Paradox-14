// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Singularity.Components;

namespace Content.Server.ParticleAccelerator.Components;

[RegisterComponent]
public sealed partial class ParticleProjectileComponent : Component
{
    public ParticleAcceleratorPowerState State;
}
