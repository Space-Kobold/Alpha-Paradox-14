// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using JetBrains.Annotations;
using Robust.Shared.Console;
using Robust.Shared.Toolshed;

namespace Content.Shared.Administration
{
    /// <summary>
    ///     Specifies that a command can be executed by any player.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    [MeansImplicitUse]
    public sealed class AnyCommandAttribute : Attribute
    {

    }
}
