// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Sound.Components;
using Robust.Shared.GameStates;

namespace Content.Shared.Audio;

/// <summary>
/// Toggles <see cref="AmbientSoundComponent"/> and <see cref="SpamEmitSoundComponent"/> off when this entity's MobState isn't Alive.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class SoundWhileAliveComponent : Component;
