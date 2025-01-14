// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Server.LandMines;

[RegisterComponent]
public sealed partial class LandMineComponent : Component
{
    /// <summary>
    /// Trigger sound effect when stepping onto landmine
    /// </summary>
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public SoundSpecifier? Sound;
}
