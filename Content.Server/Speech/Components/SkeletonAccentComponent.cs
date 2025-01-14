// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Speech.Components;

/// <summary>
///     Rattle me bones!
/// </summary>
[RegisterComponent]
public sealed partial class SkeletonAccentComponent : Component
{
    /// <summary>
    ///     Chance that the message will be appended with "ACK ACK!"
    /// </summary>
    [DataField("ackChance")]
    public float ackChance = 0.3f; // Funnier if it doesn't happen every single time
}
