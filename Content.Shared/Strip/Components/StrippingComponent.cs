// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Strip.Components
{
    /// <summary>
    ///     Give to an entity to say they can strip another entity.
    /// </summary>
    [RegisterComponent, NetworkedComponent]
    public sealed partial class StrippingComponent : Component {}
}
