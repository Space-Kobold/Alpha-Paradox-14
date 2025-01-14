// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Magic;

public interface ISpeakSpell // The speak n spell interface
{
    /// <summary>
    /// Localized string spoken by the caster when casting this spell.
    /// </summary>
    public string? Speech { get; }
}
