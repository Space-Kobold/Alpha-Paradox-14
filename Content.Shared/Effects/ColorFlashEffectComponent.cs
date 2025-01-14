// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Effects;

/// <summary>
/// Stores the original sprite color for flashing entity to be able to restore it later.
/// </summary>
[RegisterComponent]
public sealed partial class ColorFlashEffectComponent : Component
{
    [ViewVariables]
    public Color Color = Color.White;
}
