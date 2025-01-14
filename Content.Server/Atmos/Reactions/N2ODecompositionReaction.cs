// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos.EntitySystems;
using Content.Shared.Atmos;
using Content.Shared.Atmos.Reactions;
using JetBrains.Annotations;

namespace Content.Server.Atmos.Reactions;

/// <summary>
///     Decomposes Nitrous Oxide into Nitrogen and Oxygen.
/// </summary>
[UsedImplicitly]
public sealed partial class N2ODecompositionReaction : IGasReactionEffect
{
    public ReactionResult React(GasMixture mixture, IGasMixtureHolder? holder, AtmosphereSystem atmosphereSystem, float heatScale)
    {
        var cacheN2O = mixture.GetMoles(Gas.NitrousOxide);

        var burnedFuel = cacheN2O / Atmospherics.N2ODecompositionRate;

        if (burnedFuel <= 0 || cacheN2O - burnedFuel < 0)
            return ReactionResult.NoReaction;

        mixture.AdjustMoles(Gas.NitrousOxide, -burnedFuel);
        mixture.AdjustMoles(Gas.Nitrogen, burnedFuel);
        mixture.AdjustMoles(Gas.Oxygen, burnedFuel / 2);

        return ReactionResult.Reacting;
    }
}
