// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Materials;

[RegisterComponent]
public sealed partial class RecyclerVisualsComponent : Component
{
    /// <summary>
    /// Key appended to state string if bloody.
    /// </summary>
    [DataField]
    public string BloodyKey = "bld";

    /// <summary>
    /// Base key for the visual state.
    /// </summary>
    [DataField]
    public string BaseKey = "grinder-o";
}
