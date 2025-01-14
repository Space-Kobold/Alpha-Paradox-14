// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Speech.Components;

/// <summary>
///     Nyehh, my gabagool, see?
///     Etc etc.
/// </summary>
[RegisterComponent]
public sealed partial class MobsterAccentComponent : Component
{
    /// <summary>
    ///     Do you make all the rules?
    /// </summary>
    [DataField("isBoss")]
    public bool IsBoss = true;
}
