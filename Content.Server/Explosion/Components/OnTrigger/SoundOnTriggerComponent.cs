// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.EntitySystems;
using Robust.Shared.Audio;

namespace Content.Server.Explosion.Components;

/// <summary>
/// Will play sound from the attached entity upon a <see cref="TriggerEvent"/>.
/// </summary>
[RegisterComponent]
public sealed partial class SoundOnTriggerComponent : Component
{
    [DataField("removeOnTrigger")]
    public bool RemoveOnTrigger = true;

    [DataField("sound")]
    public SoundSpecifier? Sound = new SoundPathSpecifier("/Audio/Effects/Grenades/supermatter_start.ogg");
}
