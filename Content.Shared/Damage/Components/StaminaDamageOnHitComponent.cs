// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Audio;

namespace Content.Shared.Damage.Components;

[RegisterComponent]
public sealed partial class StaminaDamageOnHitComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite), DataField("damage")]
    public float Damage = 30f;

    [DataField("sound")]
    public SoundSpecifier? Sound;
}
