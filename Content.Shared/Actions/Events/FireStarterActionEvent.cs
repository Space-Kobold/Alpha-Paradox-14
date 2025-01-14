// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Actions.Events;

public sealed partial class FireStarterActionEvent : InstantActionEvent
{
    /// <summary>
    /// Increases the number of fire stacks when a flammable object is ignited.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite)]
    public float Severity = 0.3f;
}
