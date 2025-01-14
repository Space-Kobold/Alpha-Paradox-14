// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised broadcast whenever a shuttle FTLs
/// </summary>
[ByRefEvent]
public readonly record struct ShuttleFlattenEvent(EntityUid MapUid, List<Box2> AABBs);
