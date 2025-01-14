// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Roles;

/// <summary>
/// Adds a briefing to the character info menu, does nothing else.
/// </summary>
[RegisterComponent]
public sealed partial class RoleBriefingComponent : Component
{
    [DataField("briefing"), ViewVariables(VVAccess.ReadWrite)]
    public string Briefing;
}
