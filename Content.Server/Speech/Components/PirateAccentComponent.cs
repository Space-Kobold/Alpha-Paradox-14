// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Speech.EntitySystems;

namespace Content.Server.Speech.Components;

[RegisterComponent]
[Access(typeof(PirateAccentSystem))]
public sealed partial class PirateAccentComponent : Component
{
    [ViewVariables(VVAccess.ReadWrite)]
    [DataField("yarrChance")]
    public float YarrChance = 0.5f;

    [ViewVariables]
    public readonly List<string> PirateWords = new()
    {
        "accent-pirate-prefix-1",
        "accent-pirate-prefix-2",
        "accent-pirate-prefix-3",
        "accent-pirate-prefix-4",
    };
}
