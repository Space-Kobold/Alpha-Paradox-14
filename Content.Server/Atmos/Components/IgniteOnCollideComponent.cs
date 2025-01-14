// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Server.Atmos.EntitySystems;

namespace Content.Server.Atmos.Components;

[RegisterComponent, Access(typeof(FlammableSystem))]
public sealed partial class IgniteOnCollideComponent : Component
{
    /// <summary>
    /// How many more times the ignition can be applied.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("count")]
    public int Count = 1;

    [ViewVariables(VVAccess.ReadWrite), DataField("fireStacks")]
    public float FireStacks;

    [ViewVariables(VVAccess.ReadWrite), DataField("fixtureId")]
    public string FixtureId = "ignition";

}
