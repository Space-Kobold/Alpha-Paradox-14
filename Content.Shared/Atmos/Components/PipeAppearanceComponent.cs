// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Utility;

namespace Content.Shared.Atmos.Components;

[RegisterComponent]
public sealed partial class PipeAppearanceComponent : Component
{
    [DataField("sprite")]
    public SpriteSpecifier.Rsi Sprite = new(new("Structures/Piping/Atmospherics/pipe.rsi"), "pipeConnector");
}
