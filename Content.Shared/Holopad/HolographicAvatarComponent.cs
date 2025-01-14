// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Robust.Shared.GameStates;

namespace Content.Shared.Holopad;

[RegisterComponent, NetworkedComponent]
public sealed partial class HolographicAvatarComponent : Component
{
    /// <summary>
    /// The prototype sprite layer data for the hologram
    /// </summary>
    [DataField]
    public PrototypeLayerData[] LayerData;
}
