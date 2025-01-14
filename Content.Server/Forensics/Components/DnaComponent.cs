// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Forensics;

/// <summary>
/// This component is for mobs that have DNA.
/// </summary>
[RegisterComponent]
public sealed partial class DnaComponent : Component
{
    [DataField("dna"), ViewVariables(VVAccess.ReadWrite)]
    public string DNA = String.Empty;
}
