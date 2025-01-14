// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Explosion.EntitySystems;
using Content.Shared.Sound.Components;

namespace Content.Server.Sound.Components
{
    /// <summary>
    /// Whenever a <see cref="TriggerEvent"/> is run play a sound in PVS range.
    /// </summary>
    [RegisterComponent]
    public sealed partial class EmitSoundOnTriggerComponent : BaseEmitSoundComponent
    {
    }
}
