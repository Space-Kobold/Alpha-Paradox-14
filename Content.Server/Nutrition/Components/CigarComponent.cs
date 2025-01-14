// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Nutrition.EntitySystems;

namespace Content.Server.Nutrition.Components
{
    /// <summary>
    ///     A disposable, single-use smokable.
    /// </summary>
    [RegisterComponent, Access(typeof(SmokingSystem))]
    public sealed partial class CigarComponent : Component
    {
    }
}
