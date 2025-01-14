// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.Distance;

/// <summary>
/// Produces a rounder shape useful for more natural areas.
/// </summary>
public sealed partial class DunGenEuclideanSquaredDistance : IDunGenDistance
{
    [DataField]
    public float BlendWeight { get; set; } = 0.50f;
}
