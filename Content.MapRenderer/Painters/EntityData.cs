// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Client.GameObjects;
using Robust.Shared.GameObjects;

namespace Content.MapRenderer.Painters;

public readonly record struct EntityData(EntityUid Owner, SpriteComponent Sprite, float X, float Y)
{
    public readonly EntityUid Owner = Owner;

    public readonly SpriteComponent Sprite = Sprite;

    public readonly float X = X;

    public readonly float Y = Y;
}
