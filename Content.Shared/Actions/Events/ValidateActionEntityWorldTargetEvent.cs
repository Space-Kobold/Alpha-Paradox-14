// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;

namespace Content.Shared.Actions.Events;

[ByRefEvent]
public record struct ValidateActionEntityWorldTargetEvent(
    EntityUid User,
    EntityUid? Target,
    EntityCoordinates? Coords,
    bool Cancelled = false);
