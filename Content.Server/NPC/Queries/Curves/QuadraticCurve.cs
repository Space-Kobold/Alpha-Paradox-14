// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.NPC.Queries.Curves;

public sealed partial class QuadraticCurve : IUtilityCurve
{
    [DataField("slope")] public  float Slope = 1f;

    [DataField("exponent")] public  float Exponent = 1f;

    [DataField("yOffset")] public  float YOffset;

    [DataField("xOffset")] public  float XOffset;
}
