// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Sprite;

namespace Content.Client.Sprite;

/// <summary>
/// The non-networked client-only component to track active <see cref="SpriteFadeComponent"/>
/// </summary>
[RegisterComponent, Access(typeof(SpriteFadeSystem))]
public sealed partial class FadingSpriteComponent : Component
{
    [ViewVariables]
    public float OriginalAlpha;
}
