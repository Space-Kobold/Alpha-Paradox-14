// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Roles
{
    /// <summary>
    ///     Provides special hooks for when jobs get spawned in/equipped.
    /// </summary>
    [ImplicitDataDefinitionForInheritors]
    public abstract partial class JobSpecial
    {
        public abstract void AfterEquip(EntityUid mob);
    }
}
