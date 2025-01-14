// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

namespace Content.Server.Nuke;

/// <summary>
///     This generates a label for a nuclear bomb.
/// </summary>
/// <remarks>
///     This is a separate component because the fake nuclear bomb keg exists.
/// </remarks>
[RegisterComponent]
public sealed partial class NukeLabelComponent : Component
{
    [DataField] public LocId Prefix = "nuke-label-nanotrasen";
    [DataField] public int SerialLength = 6;
}
