// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared.Sound.Components;

/// <summary>
/// Simple sound emitter that emits sound on AfterActivatableUIOpenEvent
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class EmitSoundOnUIOpenComponent : BaseEmitSoundComponent
{
    /// <summary>
    /// Blacklist for making the sound not play if certain entities open the UI
    /// </summary>
    [DataField]
    public EntityWhitelist Blacklist = new();
}
