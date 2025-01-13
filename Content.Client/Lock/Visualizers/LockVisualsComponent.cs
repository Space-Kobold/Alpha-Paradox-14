// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Lock.Visualizers;

[RegisterComponent]
[Access(typeof(LockVisualizerSystem))]
public sealed partial class LockVisualsComponent : Component
{
    /// <summary>
    /// The RSI state used for the lock indicator while the entity is locked.
    /// </summary>
    [DataField("stateLocked")]
    [ViewVariables(VVAccess.ReadWrite)]
    public string? StateLocked = "locked";

    /// <summary>
    /// The RSI state used for the lock indicator entity is unlocked.
    /// </summary>
    [DataField("stateUnlocked")]
    [ViewVariables(VVAccess.ReadWrite)]
    public string? StateUnlocked = "unlocked";
}
