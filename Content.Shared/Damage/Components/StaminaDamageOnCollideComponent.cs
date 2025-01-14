// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Shared.Damage.Components;

/// <summary>
/// Applies stamina damage when colliding with an entity.
/// </summary>
[RegisterComponent]
public sealed partial class StaminaDamageOnCollideComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("damage")]
    public float Damage = 55f;

    [DataField("sound")]
    public SoundSpecifier? Sound;
}
