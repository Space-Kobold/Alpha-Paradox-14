// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Atmos
{
    public sealed class ExcitedGroup
    {
        [ViewVariables] public bool Disposed = false;

        [ViewVariables] public readonly List<TileAtmosphere> Tiles = new(100);

        [ViewVariables] public int DismantleCooldown { get; set; } = 0;

        [ViewVariables] public int BreakdownCooldown { get; set; } = 0;
    }
}
