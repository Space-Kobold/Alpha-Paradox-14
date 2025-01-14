// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.CCVar;

namespace Content.Server.Radiation.Systems;

// cvar updates
public partial class RadiationSystem
{
    public float MinIntensity { get; private set; }
    public float GridcastUpdateRate { get; private set; }
    public bool GridcastSimplifiedSameGrid { get; private set; }
    public float GridcastMaxDistance { get; private set; }

    private void SubscribeCvars()
    {
        Subs.CVar(_cfg, CCVars.RadiationMinIntensity, radiationMinIntensity => MinIntensity = radiationMinIntensity, true);
        Subs.CVar(_cfg, CCVars.RadiationGridcastUpdateRate, updateRate => GridcastUpdateRate = updateRate, true);
        Subs.CVar(_cfg, CCVars.RadiationGridcastSimplifiedSameGrid, simplifiedSameGrid => GridcastSimplifiedSameGrid = simplifiedSameGrid, true);
        Subs.CVar(_cfg, CCVars.RadiationGridcastMaxDistance, maxDistance => GridcastMaxDistance = maxDistance, true);
    }
}
