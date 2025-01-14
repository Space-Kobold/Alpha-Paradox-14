// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Forensics;

/// <summary>
/// This controls residues left on items
/// which the forensics system uses.
/// </summary>
[RegisterComponent]
public sealed partial class ResidueComponent : Component
{
    [DataField]
    public LocId ResidueAdjective = "residue-unknown";

    [DataField]
    public string? ResidueColor;
}
