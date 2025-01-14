// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.Map;

namespace Content.Server.Shuttles.Events;

/// <summary>
/// Raised when a shuttle has moved to FTL space.
/// </summary>
[ByRefEvent]
public readonly record struct FTLStartedEvent(EntityUid Entity, EntityCoordinates TargetCoordinates, EntityUid? FromMapUid, Matrix3x2 FTLFrom, Angle FromRotation);
