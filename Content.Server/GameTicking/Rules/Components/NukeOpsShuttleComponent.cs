// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.GameTicking.Rules.Components;

/// <summary>
/// Tags grid as nuke ops shuttle
/// </summary>
[RegisterComponent]
public sealed partial class NukeOpsShuttleComponent : Component
{
    [DataField]
    public EntityUid AssociatedRule;
}
