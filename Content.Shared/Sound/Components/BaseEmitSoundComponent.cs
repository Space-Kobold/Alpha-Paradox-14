// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Shared.Sound.Components;

/// <summary>
/// Base sound emitter which defines most of the data fields.
/// Accepts both single sounds and sound collections.
/// </summary>
public abstract partial class BaseEmitSoundComponent : Component
{
    public static readonly AudioParams DefaultParams = AudioParams.Default.WithVolume(-2f);

    [AutoNetworkedField]
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField(required: true)]
    public SoundSpecifier? Sound;

    /// <summary>
    /// Play the sound at the position instead of parented to the source entity.
    /// Useful if the entity is deleted after.
    /// </summary>
    [DataField]
    public bool Positional;
}
