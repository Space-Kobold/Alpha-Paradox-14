// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos;
using Content.Shared.Atmos;
using JetBrains.Annotations;

namespace Content.Server.Destructible.Thresholds.Behaviors;

[UsedImplicitly]
[DataDefinition]
public sealed partial class SpawnGasBehavior : IThresholdBehavior
{
    [DataField("gasMixture", required: true)]
    public GasMixture Gas = new();

    public void Execute(EntityUid owner, DestructibleSystem system, EntityUid? cause = null)
    {
        var air = system.AtmosphereSystem.GetContainingMixture(owner, false, true);

        if (air != null)
            system.AtmosphereSystem.Merge(air, Gas);
    }
}
