// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.Item.ItemToggle.Components;

/// <summary>
/// Handles the active sound being played continuously with some items that are activated (ie e-sword hum).
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ItemToggleActiveSoundComponent : Component
{
    /// <summary>
    ///     The continuous noise this item makes when it's activated (like an e-sword's hum).
    /// </summary>
    [DataField(required: true), AutoNetworkedField]
    public SoundSpecifier? ActiveSound;

    /// <summary>
    ///     Used when the item emits sound while active.
    /// </summary>
    [DataField]
    public EntityUid? PlayingStream;
}
