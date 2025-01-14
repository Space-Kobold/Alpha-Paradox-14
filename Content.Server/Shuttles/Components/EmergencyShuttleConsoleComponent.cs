// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Components;

[RegisterComponent]
public sealed partial class EmergencyShuttleConsoleComponent : Component
{
    // TODO: Okay doing it by string is kinda suss but also ID card tracking doesn't seem to be robust enough

    /// <summary>
    /// ID cards that have been used to authorize an early launch.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("authorized")]
    public HashSet<string> AuthorizedEntities = new();

    [ViewVariables(VVAccess.ReadWrite), DataField("authorizationsRequired")]
    public int AuthorizationsRequired = 3;
}
