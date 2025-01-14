// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.StationEvents.Events;
using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server.StationEvents.Components;

[RegisterComponent, Access(typeof(BureaucraticErrorRule))]
public sealed partial class BureaucraticErrorRuleComponent : Component
{
    /// <summary>
    /// The jobs that are ignored by this rule and won't have their slots changed.
    /// </summary>
    [DataField]
    public List<ProtoId<JobPrototype>> IgnoredJobs = new();
}
