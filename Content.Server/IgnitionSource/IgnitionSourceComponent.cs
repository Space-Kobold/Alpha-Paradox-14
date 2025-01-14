// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.IgnitionSource;

/// <summary>
/// This is used for creating atmosphere hotspots while ignited to start reactions such as fire.
/// </summary>
[RegisterComponent, Access(typeof(IgnitionSourceSystem))]
public sealed partial class IgnitionSourceComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public bool Ignited;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public int Temperature = 700;
}
