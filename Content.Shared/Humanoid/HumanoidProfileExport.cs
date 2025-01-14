// SPDX-FileCopyrightText: 2017-2025 Space Wizards Federation and Contributors <https://github.com/space-wizards/space-station-14>
//
// SPDX-License-Identifier: LicenseRef-MIT-SpaceWizards

using Content.Shared.Preferences;

namespace Content.Shared.Humanoid;

/// <summary>
/// Holds all of the data for importing / exporting character profiles.
/// </summary>
[DataDefinition]
public sealed partial class HumanoidProfileExport
{
    [DataField]
    public string ForkId;

    [DataField]
    public int Version = 1;

    [DataField(required: true)]
    public HumanoidCharacterProfile Profile = default!;
}
