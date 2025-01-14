// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Silicons.StationAi;
using Robust.Shared.GameStates;

namespace Content.Shared.StationAi;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, Access(typeof(SharedStationAiSystem))]
public sealed partial class StationAiVisionComponent : Component
{
    [DataField, AutoNetworkedField]
    public bool Enabled = true;

    [DataField, AutoNetworkedField]
    public bool Occluded = true;

    /// <summary>
    /// Range in tiles
    /// </summary>
    [DataField, AutoNetworkedField]
    public float Range = 7.5f;
}
