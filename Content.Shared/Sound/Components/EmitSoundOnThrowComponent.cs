// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Sound.Components;

/// <summary>
/// Simple sound emitter that emits sound on ThrowEvent
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class EmitSoundOnThrowComponent : BaseEmitSoundComponent
{
}
