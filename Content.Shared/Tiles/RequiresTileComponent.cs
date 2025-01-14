// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Tiles;

/// <summary>
/// Deletes the entity if the tile changes from under it. Used for visual effects.
/// </summary>
[RegisterComponent, NetworkedComponent]
public sealed partial class RequiresTileComponent : Component
{

}
