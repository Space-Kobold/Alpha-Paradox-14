// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Chemistry.Reagent;
using Content.Shared.EntityEffects;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Server.Tiles;

/// <summary>
/// Applies effects upon stepping onto a tile.
/// </summary>
[RegisterComponent, Access(typeof(TileEntityEffectSystem))]
public sealed partial class TileEntityEffectComponent : Component
{
    /// <summary>
    /// List of effects that should be applied.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField]
    public List<EntityEffect> Effects = default!;
}
