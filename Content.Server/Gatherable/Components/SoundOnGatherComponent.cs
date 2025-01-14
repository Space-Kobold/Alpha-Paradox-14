// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Audio;
using Robust.Shared.Audio;

namespace Content.Server.Gatherable.Components;

/// <summary>
/// Plays the specified sound when this entity is gathered.
/// </summary>
[RegisterComponent, Access(typeof(GatherableSystem))]
public sealed partial class SoundOnGatherComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("sound")]
    public SoundSpecifier Sound = new SoundPathSpecifier("/Audio/Effects/break_stone.ogg")
    {
        Params = AudioParams.Default
            .WithVariation(SharedContentAudioSystem.DefaultVariation)
            .WithVolume(-3f),
    };
}
