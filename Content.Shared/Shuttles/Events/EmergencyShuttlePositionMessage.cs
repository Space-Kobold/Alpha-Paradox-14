// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.Events;

/// <summary>
/// For debugging the expected emergency shuttle position.
/// </summary>
[Serializable, NetSerializable]
public sealed class EmergencyShuttlePositionMessage : EntityEventArgs
{
    public NetEntity? StationUid;
    public Box2? Position;
}
