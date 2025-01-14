// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Serialization;

namespace Content.Shared.Weapons.Ranged.Events;

/// <summary>
/// Raised on the client to request it would like to stop hooting.
/// </summary>
[Serializable, NetSerializable]
public sealed class RequestStopShootEvent : EntityEventArgs
{
    public NetEntity Gun;
}
