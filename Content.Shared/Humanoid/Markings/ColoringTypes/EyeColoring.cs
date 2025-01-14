// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Humanoid.Markings;

/// <summary>
///     Colors layer in an eye color
/// </summary>
public sealed partial class EyeColoring : LayerColoringType
{
    public override Color? GetCleanColor(Color? skin, Color? eyes, MarkingSet markingSet)
    {
        return eyes;
    }
}
