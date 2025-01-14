// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Limits the number of traitors that can have the same objective.
/// Checked by the prototype id, so only considers the exact same objectives.
/// </summary>
/// <remarks>
/// Only works for traitors so don't use for anything else.
/// </remarks>
[RegisterComponent, Access(typeof(ObjectiveLimitSystem))]
public sealed partial class ObjectiveLimitComponent : Component
{
    /// <summary>
    /// Max number of players
    /// </summary>
    [DataField(required: true), ViewVariables(VVAccess.ReadWrite)]
    public uint Limit;
}
