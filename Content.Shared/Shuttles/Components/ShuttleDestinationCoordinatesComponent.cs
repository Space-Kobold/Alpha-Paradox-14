// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Shared.Shuttles.Components;
using Robust.Shared.GameStates;

/// <summary>
/// Enables a shuttle to travel to a destination with an item inserted into its console
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ShuttleDestinationCoordinatesComponent : Component
{
    /// <summary>
    /// Uid for entity containing the FTLDestination component
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField, AutoNetworkedField]
    public EntityUid? Destination;
}
