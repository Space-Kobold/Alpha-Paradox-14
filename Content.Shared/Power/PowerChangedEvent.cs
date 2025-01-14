// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Power;

/// <summary>
/// Raised whenever an ApcPowerReceiver becomes powered / unpowered.
/// Does nothing on the client.
/// </summary>
[ByRefEvent]
public readonly record struct PowerChangedEvent(bool Powered, float ReceivingPower);