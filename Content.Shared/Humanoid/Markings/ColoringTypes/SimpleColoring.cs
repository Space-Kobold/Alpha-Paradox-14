// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Humanoid.Markings;

/// <summary>
///     Colors layer in a specified color
/// </summary>
public sealed partial class SimpleColoring : LayerColoringType
{
    [DataField("color", required: true)]
    public Color Color = Color.White;

    public override Color? GetCleanColor(Color? skin, Color? eyes, MarkingSet markingSet)
    {
        return Color;
    }
}
