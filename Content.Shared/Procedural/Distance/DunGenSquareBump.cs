// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Procedural.Distance;

/// <summary>
/// Produces a squarish-shape that's better for filling in most of the area.
/// </summary>
public sealed partial class DunGenSquareBump : IDunGenDistance
{
    [DataField]
    public float BlendWeight { get; set; } = 0.50f;
}
