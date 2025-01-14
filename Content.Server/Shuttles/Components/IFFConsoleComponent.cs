// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;
using Content.Shared.Shuttles.Components;

namespace Content.Server.Shuttles.Components;

[RegisterComponent, Access(typeof(ShuttleSystem))]
public sealed partial class IFFConsoleComponent : Component
{
    /// <summary>
    /// Flags that this console is allowed to set.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("allowedFlags")]
    public IFFFlags AllowedFlags = IFFFlags.HideLabel;
}
