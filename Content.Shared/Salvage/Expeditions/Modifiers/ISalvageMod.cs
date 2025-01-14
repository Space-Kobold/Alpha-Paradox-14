// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Salvage.Expeditions.Modifiers;

public interface ISalvageMod
{
    /// <summary>
    /// Player-friendly version describing this modifier.
    /// </summary>
    LocId Description { get; }

    /// <summary>
    /// Cost for difficulty modifiers.
    /// </summary>
    float Cost { get; }
}
