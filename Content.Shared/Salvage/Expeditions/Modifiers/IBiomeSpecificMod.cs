// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Salvage.Expeditions.Modifiers;

public interface IBiomeSpecificMod : ISalvageMod
{
    /// <summary>
    /// Whitelist for biomes. If null then any biome is allowed.
    /// </summary>
    List<string>? Biomes { get; }
}
