// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Bed.Sleep
{
    /// <summary>
    /// Prevents waking up. Use as a status effect.
    /// </summary>
    [NetworkedComponent, RegisterComponent]
    public sealed partial class ForcedSleepingComponent : Component
    {}
}
