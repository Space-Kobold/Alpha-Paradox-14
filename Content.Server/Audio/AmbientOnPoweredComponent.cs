// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Audio;

namespace Content.Server.Audio
{
    /// <summary>
    /// Toggles <see cref="AmbientSoundComponent"/> on when powered and off when not powered.
    /// </summary>
    [RegisterComponent]
    public sealed partial class AmbientOnPoweredComponent : Component
    {
    }
}
