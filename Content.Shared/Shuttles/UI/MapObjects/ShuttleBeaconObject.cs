// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.Map;
using Robust.Shared.Serialization;

namespace Content.Shared.Shuttles.UI.MapObjects;

[Serializable, NetSerializable]
public readonly record struct ShuttleBeaconObject(NetEntity Entity, NetCoordinates Coordinates, string Name) : IMapObject
{
    public bool HideButton => false;
}
