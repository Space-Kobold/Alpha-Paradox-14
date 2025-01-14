// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.DeviceNetwork;
using Content.Shared.DeviceNetwork;

namespace Content.Server.DeviceLinking.Events;

[ByRefEvent]
public readonly record struct SignalReceivedEvent(string Port, EntityUid? Trigger = null, NetworkPayload? Data = null);
