// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Atmos
{
    /// <summary>
    ///     Event raised directed to an entity when it is standing on a tile that's on fire.
    /// </summary>
    [ByRefEvent]
    public readonly struct TileFireEvent
    {
        public readonly float Temperature;
        public readonly float Volume;

        public TileFireEvent(float temperature, float volume)
        {
            Temperature = temperature;
            Volume = volume;
        }
    }
}
