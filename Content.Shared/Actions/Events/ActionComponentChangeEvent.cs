// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Prototypes;

namespace Content.Shared.Actions.Events;

/// <summary>
/// Adds / removes the component upon action.
/// </summary>
[Virtual]
public partial class ActionComponentChangeEvent : InstantActionEvent
{
    [DataField(required: true)]
    public ComponentRegistry Components = new();
}

/// <summary>
/// Similar to <see cref="ActionComponentChangeEvent"/> except raises an event to attempt to relay it.
/// </summary>
public sealed partial class RelayedActionComponentChangeEvent : ActionComponentChangeEvent
{

}

[ByRefEvent]
public record struct AttemptRelayActionComponentChangeEvent
{
    public EntityUid? Target;
}
