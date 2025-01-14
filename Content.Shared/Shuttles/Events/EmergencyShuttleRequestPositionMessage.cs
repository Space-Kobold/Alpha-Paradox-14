// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.Events;

/// <summary>
/// Raised on the client to request the expected position of the emergency shuttle for debugging.
/// </summary>
[Serializable, NetSerializable]
public sealed class EmergencyShuttleRequestPositionMessage : EntityEventArgs
{

}
