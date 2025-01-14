// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Throwing
{
    /// <summary>
    ///     Makes an item land at the cursor when thrown and slide a little further.
    ///     Without it the item lands slightly in front and stops moving at the cursor.
    ///     Use this for throwing weapons that should pierce the opponent, for example spears.
    /// </summary>
    [RegisterComponent, NetworkedComponent]
    public sealed partial class LandAtCursorComponent : Component { }
}
