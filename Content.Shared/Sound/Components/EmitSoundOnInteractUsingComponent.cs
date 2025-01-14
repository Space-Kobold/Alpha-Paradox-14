// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Whitelist;
using Robust.Shared.Prototypes;
using Robust.Shared.GameStates;

namespace Content.Shared.Sound.Components;

/// <summary>
/// Whenever this item is used upon by an entity, with a tag or component within a whitelist, in the hand of a user, play a sound
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class EmitSoundOnInteractUsingComponent : BaseEmitSoundComponent
{
    [DataField(required: true)]
    public EntityWhitelist Whitelist = new();
}
