// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Zombies;

/// <summary>
/// Overrides the applied accent for zombies.
/// </summary>
[RegisterComponent]
public sealed partial class ZombieAccentOverrideComponent : Component
{
    [DataField("accent")]
    public string Accent = "zombie";
}
