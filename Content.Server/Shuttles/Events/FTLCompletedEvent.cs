// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Shuttles.Systems;

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised when <see cref="ShuttleSystem.FasterThanLight"/> has completed FTL Travel.
/// </summary>
[ByRefEvent]
public readonly record struct FTLCompletedEvent(EntityUid Entity, EntityUid MapUid);
