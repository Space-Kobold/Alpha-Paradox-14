// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using System.Numerics;
using Robust.Shared.GameStates;

namespace Content.Shared.Placeable;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(PlaceableSurfaceSystem))]
public sealed partial class PlaceableSurfaceComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool IsPlaceable { get; set; } = true;

    [DataField, AutoNetworkedField]
    public bool PlaceCentered { get; set; }

    [DataField, AutoNetworkedField]
    public Vector2 PositionOffset { get; set; }
}
