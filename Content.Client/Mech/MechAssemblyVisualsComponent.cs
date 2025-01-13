// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Client.Mech;

/// <summary>
/// This is used for visualizing mech constructions
/// </summary>
[RegisterComponent]
public sealed partial class MechAssemblyVisualsComponent : Component
{
    /// <summary>
    /// The prefix that is followed by the number which
    /// denotes the current state to use.
    /// </summary>
    [DataField("statePrefix", required: true)]
    public string StatePrefix = string.Empty;
}
